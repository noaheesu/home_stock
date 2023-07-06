using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class BathroomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
