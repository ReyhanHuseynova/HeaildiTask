using Microsoft.AspNetCore.Mvc;

namespace ProjectH.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
