using System;

namespace SinusSkateboards.Domain.Entities
{
    public class ProductAttribute
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual AttributeType AttributeType { get; set; }
    }
}