using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SinusSkateboards.Application.Abstract;
using SinusSkateboards.Domain.Enums;

namespace SinusSkateboards.UI.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private readonly IOrderStatusService _orderStatusService;
        public IndexModel(IOrderStatusService orderStatusService)
        {
            _orderStatusService = orderStatusService;

        }
        public int Processing { get; set; }
        public int Cancelled { get; set; }
        public int Refunded { get; set; }
        public int Delivered { get; set; }
        public async Task OnGet()
        {
            var orderStatus = await _orderStatusService.Get(OrderStatuses.Processing.ToString());
            Processing = orderStatus.Orders.Count();
            orderStatus = await _orderStatusService.Get(OrderStatuses.Cancelled.ToString());
            Cancelled = orderStatus.Orders.Count();
            orderStatus = await _orderStatusService.Get(OrderStatuses.Refunded.ToString());
            Refunded = orderStatus.Orders.Count();
            orderStatus = await _orderStatusService.Get(OrderStatuses.Delivered.ToString());
            Delivered = orderStatus.Orders.Count();
        }
    }
}
