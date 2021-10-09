using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SinusSkateboards.Domain.Entities
{
    public class OrderDetail
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
    }
}