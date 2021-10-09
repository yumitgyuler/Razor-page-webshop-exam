using System;
using System.Collections.Generic;

namespace SinusSkateboards.Domain.Entities
{
    public class AttributeType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual List<ProductAttribute> ProductAttributes { get; set; }
    }
}