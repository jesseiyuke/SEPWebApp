using Microsoft.AspNetCore.Mvc;
using SEP.DataAccess;
using SEP.Models;

namespace SEPWebApp.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ApplicationDbContext _db;
        public RegistrationController(ApplicationDbContext db) {
            _db = db;
        }
        public IActionResult Index(User obj)
        {

            if (ModelState.IsValid)
            {
                _db.User.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Registration successful";
         

                if (obj.Role == 0)
                {
                    return RedirectToAction("Index","Employer");
                }
                else
                {
                    return RedirectToAction("Index", "Student");
                }

            }
            else
            {
                return View(obj);
            }
        }
    }
}
