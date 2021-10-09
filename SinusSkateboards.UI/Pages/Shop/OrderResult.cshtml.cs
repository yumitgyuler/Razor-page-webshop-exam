using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SinusSkateboards.UI.Pages.Shop
{
    public class OrderResultModel : PageModel
    {
        public int OrderNumber { get; set; }
        public void OnGet(int orderNumber)
        {
            OrderNumber = orderNumber;
        }
    }
}
