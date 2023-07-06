using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class LivingRoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
