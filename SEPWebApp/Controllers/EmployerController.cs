using Microsoft.AspNetCore.Mvc;
using SEPWebApp.Data;

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
            var objEmployerList = _db.Employers.ToList();
            return View();
        }
    }
}
