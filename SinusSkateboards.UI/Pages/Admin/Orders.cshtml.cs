using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SinusSkateboards.Application.Abstract;
using SinusSkateboards.Domain.Entities;

namespace SinusSkateboards.UI.Pages.Admin
{
    public class OrdersModel : PageModel
    {
        private readonly IOrderService _orderService;

        public OrdersModel(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public List<Order> Orders { get; set; }
        public async Task OnGet()
        {
            Orders = await _orderService.GetAll();
        }
    }
}
