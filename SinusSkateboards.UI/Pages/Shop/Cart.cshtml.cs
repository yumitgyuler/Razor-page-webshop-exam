using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SinusSkateboards.Application.Abstract;
using SinusSkateboards.Application.Helpers;
using SinusSkateboards.Domain.Entities;

namespace SinusSkateboards.UI.Pages.Shop
{
    public class CartModel : PageModel
    {
        private readonly IProductService _productService;
        private readonly IProductGroupService _productGroupService;

        public List<CartItem> CartItems { get; set; }
        public CartModel(IProductService productService, IProductGroupService productGroupService)
        {
            _productService = productService;
            _productGroupService = productGroupService;
        }

        public async Task OnGet()
        {
            CartItems = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");

            var result = await _productGroupService.GetAll();
            if (CartItems is not null)
            {
                foreach (var product in CartItems)
                {
                    foreach (var item in result)
                    {
                        var findProduct = item.Products.Find(p => p.Id == product.Id);
                        if (findProduct is not null)
                        {
                            if (findProduct.DiscountedPrice != 0)
                            {
                                product.Price = findProduct.DiscountedPrice;
                                continue;
                            }
                            product.Price = findProduct.Price;
                        }
                    }
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", CartItems);
            }
        }
        public async Task<IActionResult> OnGetAdd(string id, int quantity)
        {
            var product = await _productService.Get(id);
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            UpdateCartHelper.AddToCart(cart, product, id, quantity);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return Page();
        }
    }
}
