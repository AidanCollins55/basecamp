using Microsoft.AspNetCore.Mvc;

namespace basecamp.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
