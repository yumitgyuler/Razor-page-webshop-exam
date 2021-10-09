using System;

namespace SinusSkateboards.Domain.Entities
{
    public class CartItem
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}