using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using SinusSkateboards.Domain.Entities;

namespace SinusSkateboards.Application.Helpers
{
    public static class UpdateCartHelper
    {
        public static List<CartItem> AddToCart(List<CartItem> cart, Product product, string id, int quantity)
        {
            if (cart == null)
            {
                cart = new List<CartItem>();
                cart.Add(new CartItem()
                {
                    Id = Guid.Parse(id),
                    ProductName = product.ProductGroup.Title,
                    Price = product.DiscountedPrice == 0 ? product.Price : product.DiscountedPrice,
                    Image = product.ProductGroup.Thumbnail,
                    Quantity = quantity
                });
                return cart;
            }
            else
            {
                var index = Exist(cart, id);
                if (index == -1)
                {
                    cart.Add(new CartItem()
                    {
                        Id = Guid.Parse(id),
                        ProductName = product.ProductGroup.Title,
                        Price = product.DiscountedPrice == 0 ? product.Price : product.DiscountedPrice,
                        Image = product.ProductGroup.Thumbnail,
                        Quantity = quantity
                    });
                }
                else
                {
                    var newQuantity = cart[index].Quantity + quantity;
                    cart[index].Quantity = newQuantity;
                }
                return cart;
            }
        }
        private static int Exist(List<CartItem> cartItems, string id)
        {
            return cartItems.FindIndex(p => p.Id == Guid.Parse(id));
        }
    }
}