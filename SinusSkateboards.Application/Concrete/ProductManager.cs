using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using SinusSkateboards.Application.Abstract;
using SinusSkateboards.Application.Helpers;
using SinusSkateboards.DataAccess.Abstract;
using SinusSkateboards.Domain.Entities;

namespace SinusSkateboards.Application.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ICurrencyService _currencyService;

        public ProductManager(IProductDal productDal, IHttpContextAccessor httpContextAccessor, ICurrencyService currencyService)
        {
            _currencyService = currencyService;
            _httpContextAccessor = httpContextAccessor;
            _productDal = productDal;
        }
        public Task Add(Product product)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> Get(string id)
        {
            var clientCurrency = _httpContextAccessor.HttpContext.Request.Cookies["Currency"];
            var product = await _productDal.Get(p => p.Id == Guid.Parse(id));
            if (clientCurrency == "EUR")
            {
                var exchange = await _currencyService.GetEur();
                return product.ChangeCurrency(exchange);
            }
            return product;
        }

        public async Task<List<Product>> GetAll()
        {
            var clientCurrency = _httpContextAccessor.HttpContext.Request.Cookies["Currency"];
            var products = await _productDal.GetAll();
            if (clientCurrency == "EUR")
            {
                var exchange = await _currencyService.GetEur();
                foreach (var product in products)
                {
                    product.ChangeCurrency(exchange);
                };
            }
            return products;
        }
        public async Task<List<Product>> GetByGroupId(string groupId)
        {
            var clientCurrency = _httpContextAccessor.HttpContext.Request.Cookies["Currency"];
            var products = await _productDal.GetAll(p => p.ProductGroupId == Guid.Parse(groupId));
            if (clientCurrency == "EUR")
            {
                var exchange = await _currencyService.GetEur();
                foreach (var product in products)
                {
                    product.ChangeCurrency(exchange);
                };
            }
            return products;
        }
        public Task Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}