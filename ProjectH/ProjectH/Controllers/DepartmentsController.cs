using Microsoft.AspNetCore.Mvc;

namespace ProjectH.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
