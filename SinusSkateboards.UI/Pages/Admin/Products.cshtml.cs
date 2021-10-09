using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SinusSkateboards.Application.Abstract;
using SinusSkateboards.Domain.Entities;

namespace SinusSkateboards.UI.Pages.Admin
{
    public class ProductsModel : PageModel
    {
        private readonly IProductGroupService _productGroupService;
        private readonly ICurrencyService _currencyService;
        public ProductsModel(IProductGroupService productGroupService, ICurrencyService currencyService)
        {
            _currencyService = currencyService;
            _productGroupService = productGroupService;

        }
        public List<ProductGroup> ProductGroups { get; set; }
        public decimal ExchangeEur { get; set; }
        public async Task OnGet()
        {
            ProductGroups = await _productGroupService.GetAll();
            ProductGroups = ProductGroups.OrderBy(p => p.ParrentSku).ToList();
            ExchangeEur = await _currencyService.GetEur();
        }
    }
}
