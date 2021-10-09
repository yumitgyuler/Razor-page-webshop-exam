using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SinusSkateboards.Application.Abstract;
using SinusSkateboards.Domain.Entities;

namespace SinusSkateboards.UI.Pages.Admin
{
    public class OrderDetailModel : PageModel
    {
        private readonly IOrderService _orderService;

        public OrderDetailModel(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public Order Order { get; set; }
        public async Task OnGet(string id)
        {
            Order = await _orderService.GetById(id);
        }
    }
}
