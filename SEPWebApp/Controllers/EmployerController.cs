using Microsoft.AspNetCore.Mvc;
using SEPWebApp.Data;
using SEPWebApp.Models;

namespace SEPWebApp.Controllers
{
    public class EmployerController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EmployerController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employer obj)
        {
            return View();
        }
    }
}
