using System;
using System.Collections.Generic;

namespace SinusSkateboards.Domain.Entities
{
    public class OrderStatus
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual List<Order> Orders { get; set; }

    }
}