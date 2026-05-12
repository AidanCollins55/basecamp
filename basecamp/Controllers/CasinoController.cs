using Microsoft.AspNetCore.Mvc;

namespace basecamp.Controllers
{
    public class CasinoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
