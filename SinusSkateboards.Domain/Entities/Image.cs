using System;

namespace SinusSkateboards.Domain.Entities
{
    public class Image
    {
        public Guid Id { get; set; }
        public string Path { get; set; }
        public Guid ProductGroupId { get; set; }
        public virtual ProductGroup ProductGroup { get; set; }
    }
}