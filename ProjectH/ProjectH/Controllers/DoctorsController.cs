using Microsoft.AspNetCore.Mvc;

namespace ProjectH.Controllers
{
    public class DoctorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
