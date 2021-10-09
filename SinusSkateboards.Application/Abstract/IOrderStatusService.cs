using System.Collections.Generic;
using System.Threading.Tasks;
using SinusSkateboards.Domain.Entities;

namespace SinusSkateboards.Application.Abstract
{
    public interface IOrderStatusService
    {
        Task<OrderStatus> Get(string name);
    }
}