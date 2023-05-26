using Microsoft.AspNetCore.Mvc;

namespace SEPWebApp.Areas.Controllers
{
    [Area("Student")]
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
