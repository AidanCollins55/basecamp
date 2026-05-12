using Microsoft.AspNetCore.Mvc;

namespace basecamp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
