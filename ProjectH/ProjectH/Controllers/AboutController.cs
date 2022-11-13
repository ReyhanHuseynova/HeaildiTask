using Microsoft.AspNetCore.Mvc;

namespace ProjectH.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
