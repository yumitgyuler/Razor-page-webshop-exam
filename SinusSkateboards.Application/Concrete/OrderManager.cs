using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using SinusSkateboards.Application.Abstract;
using SinusSkateboards.DataAccess.Abstract;
using SinusSkateboards.DataAccess.Context;
using SinusSkateboards.Domain.Entities;
using SinusSkateboards.Domain.Enums;

namespace SinusSkateboards.Application.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;
        private readonly DataContext context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IOrderStatusService _orderStatusService;

        public OrderManager(IOrderDal orderDal, DataContext context, IHttpContextAccessor httpContextAccessor, IOrderStatusService orderStatusService)
        {
            _orderStatusService = orderStatusService;
            _orderDal = orderDal;
            this.context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<int> Add(List<CartItem> cartItems, ShippingAdress shippingAdress, BillingAdress billingAdress)
        {
            Order newOrder = new Order();

            var clientCurrency = _httpContextAccessor.HttpContext.Request.Cookies["Currency"];
            newOrder.OrderDetails = new List<OrderDetail>();
            foreach (var item in cartItems)
            {
                newOrder.OrderDetails.Add(new OrderDetail
                {
                    ProductId = item.Id,
                    UnitPrice = item.Price,
                    Quantity = (short)item.Quantity
                });
            }
            newOrder.OrderDate = DateTime.Now;
            newOrder.BillingAdress = billingAdress;

            if (newOrder.BillingAdress.ShipToOtherAdress)
            {
                newOrder.ShippingAdress = shippingAdress;
            }
            newOrder.Currency = clientCurrency;
            newOrder.OrderTotal = cartItems.Sum(p => p.Price);
            newOrder.OrderStatus = await _orderStatusService.Get(OrderStatuses.Processing.ToString());
            var orderNumber = await _orderDal.Add(newOrder);
            return orderNumber.OrderNumber;
        }

        public Task<List<Order>> GetAll()
        {
            return _orderDal.GetAll();
        }

        public async Task<Order> GetById(string id)
        {
            return await _orderDal.Get(p => p.Id == Guid.Parse(id));
        }
    }
}