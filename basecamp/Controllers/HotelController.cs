using Microsoft.AspNetCore.Mvc;

namespace basecamp.Controllers
{
    public class HotelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
