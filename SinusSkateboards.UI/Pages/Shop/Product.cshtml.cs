using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SinusSkateboards.Application.Abstract;
using SinusSkateboards.Application.Helpers;
using SinusSkateboards.Domain.Entities;

namespace SinusSkateboards.UI.Pages.Shop
{
    public class ProductModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly IProductGroupService _productGroupService;

        public Product Product { get; set; }
        public List<ProductGroup> ProductGroup { get; set; }
        [BindProperty]
        public CartItem cartItem { get; set; }
        public IEnumerable<IGrouping<string, ProductGroup>> ProductGroups { get; set; }
        public ProductModel(IProductService productService, IProductGroupService productGroupService)
        {
            _productGroupService = productGroupService;
            _productService = productService;
        }
        public async Task OnGet(string id)
        {
            Product = await _productService.Get(id);
            ProductGroup = await _productGroupService.GetAllByParentSku(Product.ProductGroup.ParrentSku, false);
            var result = await _productGroupService.GetAllByCategory(Product.ProductGroup.Category.Name, false);
            ProductGroups = result.GroupBy(p => p.ParrentSku);
        }
        public async Task<IActionResult> OnPost()
        {
            var product = await _productService.Get(cartItem.Id.ToString());
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            cart = UpdateCartHelper.AddToCart(cart, product, cartItem.Id.ToString(), cartItem.Quantity);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);

            Product = await _productService.Get(cartItem.Id.ToString());
            ProductGroup = await _productGroupService.GetAllByParentSku(Product.ProductGroup.ParrentSku, false);
            var result = await _productGroupService.GetAllByCategory(Product.ProductGroup.Category.Name, false);
            ProductGroups = result.GroupBy(p => p.ParrentSku);
            return Page();
        }

    }
}
