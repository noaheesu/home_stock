using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class LaundryRoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
