using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using SinusSkateboards.Application.Abstract;
using SinusSkateboards.Application.Helpers;
using SinusSkateboards.DataAccess.Abstract;
using SinusSkateboards.Domain.Entities;

namespace SinusSkateboards.Application.Concrete
{
    public class ProductGroupManager : IProductGroupService
    {
        private readonly IProductGroupDal _productGroupDal;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ICurrencyService _currencyService;
        public ProductGroupManager(IProductGroupDal productGroupDal, IHttpContextAccessor httpContextAccessor, ICurrencyService currencyService)
        {
            _currencyService = currencyService;
            _httpContextAccessor = httpContextAccessor;
            _productGroupDal = productGroupDal;

        }
        public async Task Add(ProductGroup productGroup)
        {
            if (productGroup.Thumbnail is null)
            {
                productGroup.Thumbnail = "default.png";
            }
            if (productGroup.BgColor is null)
            {
                productGroup.BgColor = "FFF";
            }

            productGroup.Products.RemoveAll(p => p.Sku == null);
            await _productGroupDal.Add(productGroup);
        }

        public Task Delete(ProductGroup productGroup)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductGroup> Get(string id)
        {
            return await _productGroupDal.Get(p => p.Id == Guid.Parse(id));
        }

        public async Task<List<ProductGroup>> GetAll()
        {
            var clientCurrency = _httpContextAccessor.HttpContext.Request.Cookies["Currency"];
            var productGroups = await _productGroupDal.GetAll();
            if (clientCurrency == "EUR")
            {
                return await PriceToEur(productGroups);
            }
            return productGroups;
        }

        public async Task<List<ProductGroup>> GetAllByCategory(string category, bool calculatePrice = true)
        {
            var clientCurrency = _httpContextAccessor.HttpContext.Request.Cookies["Currency"];
            var productGroups = await _productGroupDal.GetAll(p => p.Category.Name == category);
            if (calculatePrice == true)
            {
                if (clientCurrency == "EUR")
                {
                    return await PriceToEur(productGroups);
                }
            }
            return productGroups;
        }

        public async Task<List<ProductGroup>> GetAllByParentSku(string parentSku, bool calculatePrice = true)
        {
            var clientCurrency = _httpContextAccessor.HttpContext.Request.Cookies["Currency"];

            var productGroups = await _productGroupDal.GetAll(p => p.ParrentSku == parentSku);
            if (calculatePrice == true)
            {
                if (clientCurrency == "EUR")
                {
                    return await PriceToEur(productGroups);
                }
            }
            return productGroups;
        }

        public Task Update(ProductGroup productGroup)
        {
            if (productGroup.Thumbnail is null)
            {
                productGroup.Thumbnail = "default.png";
            }
            if (productGroup.BgColor is null)
            {
                productGroup.BgColor = "FFF";
            }
            return _productGroupDal.Update(productGroup);
        }

        private async Task<List<ProductGroup>> PriceToEur(List<ProductGroup> productGroups)
        {
            var exchange = await _currencyService.GetEur();
            foreach (var group in productGroups)
            {
                foreach (var product in group.Products)
                {
                    product.ChangeCurrency(exchange);
                }
            };
            return productGroups;
        }
    }
}