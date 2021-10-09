using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SinusSkateboards.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Sku { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        [Column(TypeName = "money")]
        public decimal DiscountedPrice { get; set; }
        public short Stock { get; set; }
        public Guid ProductAttributeId { get; set; }
        public virtual ProductAttribute ProductAttribute { get; set; }
        public Guid? ProductGroupId { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
    }
}