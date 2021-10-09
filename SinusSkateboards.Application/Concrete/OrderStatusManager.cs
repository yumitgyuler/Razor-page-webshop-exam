using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using SinusSkateboards.Application.Abstract;
using SinusSkateboards.Application.Helpers;
using SinusSkateboards.DataAccess.Abstract;
using SinusSkateboards.Domain.Entities;

namespace SinusSkateboards.Application.Concrete
{
    public class OrderStatusManager : IOrderStatusService
    {
        private readonly IOrderStatusDal _orderStatusDal;

        public OrderStatusManager(IOrderStatusDal orderStatusDal)
        {
            _orderStatusDal = orderStatusDal;

        }

        public async Task<OrderStatus> Get(string name)
        {
            return await _orderStatusDal.Get(o => o.Name == name);
        }
    }
}