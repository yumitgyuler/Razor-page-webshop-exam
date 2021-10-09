using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SinusSkateboards.Application.Abstract;
using SinusSkateboards.Application.Helpers;
using SinusSkateboards.Domain.Entities;
using SinusSkateboards.Domain.Enums;

namespace SinusSkateboards.UI.Pages.Shop
{
    public class CheckoutModel : PageModel
    {
        private readonly IProductGroupService _productGroupService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IOrderService _orderService;
        public CheckoutModel(IOrderService orderService, IProductGroupService productGroupService, IHttpContextAccessor httpContextAccessor)
        {
            _orderService = orderService;
            _httpContextAccessor = httpContextAccessor;
            _productGroupService = productGroupService;

        }
        public List<CartItem> CartItems { get; set; }
        [BindProperty]
        public BillingAdress BillingAdress { get; set; }
        [BindProperty]
        public ShippingAdress ShipingAdress { get; set; }
        public Order Order { get; set; }
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
        public async Task<IActionResult> OnPost()
        {
            var cartItems = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            var newOrderNumber = await _orderService.Add(cartItems, ShipingAdress, BillingAdress);

            cartItems = null;
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cartItems);

            return RedirectToPage("/Shop/OrderResult", new { orderNumber = newOrderNumber });
        }
    }
}
