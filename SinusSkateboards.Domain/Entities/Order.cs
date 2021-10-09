using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SinusSkateboards.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public virtual User User { get; set; }
        public string Currency { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }
        // public Guid BillingAdressId { get; set; }
        public virtual BillingAdress BillingAdress { get; set; }
        // public Guid ShippingAdressId { get; set; }
        public virtual ShippingAdress ShippingAdress { get; set; }
        [Column(TypeName = "money")]
        public decimal OrderTotal { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
    }
}