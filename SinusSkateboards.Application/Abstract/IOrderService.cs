using System.Collections.Generic;
using System.Threading.Tasks;
using SinusSkateboards.Domain.Entities;

namespace SinusSkateboards.Application.Abstract
{
    public interface IOrderService
    {
        Task<int> Add(List<CartItem> cartItems, ShippingAdress shippingAdress, BillingAdress billingAdress);
        Task<List<Order>> GetAll();
        Task<Order> GetById(string id);
    }
}