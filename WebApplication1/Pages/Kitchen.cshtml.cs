using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class KitchenModel : PageModel
    {
        private readonly ILogger<KitchenModel> _logger;

        public KitchenModel(ILogger<KitchenModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}