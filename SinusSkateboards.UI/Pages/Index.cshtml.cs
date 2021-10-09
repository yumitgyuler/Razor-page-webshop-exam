using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SinusSkateboards.Application.Abstract;
using SinusSkateboards.Application.Helpers;
using SinusSkateboards.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SinusSkateboards.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IProductGroupService _productGroupService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public IEnumerable<IGrouping<string, ProductGroup>> ProductGroups { get; set; }
        public IndexModel(IProductGroupService productGroupService, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _productGroupService = productGroupService;
        }
        public async Task OnGet()
        {
            var result = await _productGroupService.GetAll();
            ProductGroups = result.GroupBy(p => p.ParrentSku);
        }
        public async Task<IActionResult> OnPostCurrency(string currency, string path)
        {
            CookieOptions options = new CookieOptions();

            options.Expires = DateTime.Now.AddDays(2);

            if (currency == "EUR")
            {
                Response.Cookies.Append("Currency", "EUR");
            }
            else
            {
                Response.Cookies.Append("Currency", "SEK");
            };
            var result = await _productGroupService.GetAll();
            ProductGroups = result.GroupBy(p => p.ParrentSku);

            if (path == "/" || path == "/Shop/Product")
            {
                return RedirectToPage("/index");
            }
            return RedirectToPage(path);
        }
    }
}
