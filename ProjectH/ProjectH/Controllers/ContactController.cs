using Microsoft.AspNetCore.Mvc;

namespace ProjectH.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
