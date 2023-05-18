using Microsoft.AspNetCore.Mvc;

namespace SEPWebApp.Areas.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
