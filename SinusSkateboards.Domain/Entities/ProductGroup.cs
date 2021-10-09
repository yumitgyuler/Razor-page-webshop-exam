using System;
using System.Collections.Generic;

namespace SinusSkateboards.Domain.Entities
{
    public class ProductGroup
    {
        public Guid Id { get; set; }
        public string ParrentSku { get; set; }
        public string Title { get; set; }
        public string Thumbnail { get; set; }
        public virtual List<Image> Images { get; set; }
        public string ShortDescription { get; set; }
        public string DetailDescription { get; set; }
        public string BgColor { get; set; }
        public Guid? CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public Guid? ProductAttributeId { get; set; }
        public virtual ProductAttribute ProductAttribute { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}