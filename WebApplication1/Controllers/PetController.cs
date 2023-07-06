using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class PetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
