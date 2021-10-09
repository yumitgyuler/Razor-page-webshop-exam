using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SinusSkateboards.Application.Abstract;
using SinusSkateboards.Domain.Entities;

namespace SinusSkateboards.UI.Pages.Shop
{
    public class CategoriesModel : PageModel
    {
        private readonly IProductGroupService _productGroupService;
        [BindProperty]
        public IEnumerable<IGrouping<string, ProductGroup>> ProductGroups { get; set; }
        public string Title { get; set; }
        [BindProperty]
        public string SearchText { get; set; }
        [BindProperty]
        public string Color { get; set; }
        [BindProperty]
        public string Category { get; set; }
        [BindProperty]
        public string Size { get; set; }
        [BindProperty]
        public int Price { get; set; }
        public CategoriesModel(IProductGroupService productGroupService)
        {
            _productGroupService = productGroupService;
        }
        public async Task OnGet()
        {
            var result = await _productGroupService.GetAll();
            ProductGroups = result.GroupBy(p => p.ParrentSku);
        }
        public async Task OnPostSerach(string searchText)
        {
            SearchText = searchText;
            var result = await _productGroupService.GetAll();
            var filter = result.Where(p => p.Title.Contains(SearchText));
            ProductGroups = filter.GroupBy(p => p.ParrentSku);
            Title = $"Search \"{SearchText}\"";
        }
        public async Task OnPostFilter()
        {
            var result = await _productGroupService.GetAll();
            if (SearchText is not null)
            {
                result = result.Where(p => p.Title.Contains(SearchText)).ToList();
            }
            if (Color is not null)
            {
                result = result.Where(p => p.ProductAttribute.Name == Color).ToList();
            }
            if (Category is not null)
            {
                result = result.Where(p => p.Category.Name == Category).ToList();
            }
            if (Size is not null)
            {
                foreach (var item in result)
                {
                    item.Products = item.Products.Where(p => p.ProductAttribute.Name.Contains(Size)).ToList();
                }
            }
            if (Price is not 0)
            {
                foreach (var item in result)
                {
                    item.Products = item.Products.Where(p => p.DiscountedPrice < Price).ToList();
                }
            }
            ProductGroups = result.GroupBy(p => p.ParrentSku);
        }
    }
}
