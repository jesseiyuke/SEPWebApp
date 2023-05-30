using Microsoft.AspNetCore.Mvc;
using SEP.DataAccess;
using SEP.DataAccess.Repository.IRepository;
using SEP.Models;
using SEP.Models.ViewModels;

namespace SEPWebApp.Controllers
{
    [Area("Employer")]
    public class EmployerController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;

        public EmployerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        //GET
        public IActionResult Upsert(int? id)
        {
            EmployerVM employerVM = new()
            {
                Employer = new(),
                ApplicationUser = new()
            };

            return View(employerVM);


        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(EmployerVM obj)
        {

            if (ModelState.IsValid)
            {
/*                _unitOfWork.JobPost.Update(obj.ApplicationUser);
                _unitOfWork.JobPost.Update(obj.Employer);*/
                _unitOfWork.Save();
                TempData["success"] = "Profile updated successfully";
                return RedirectToAction("Index");
            }
            return View(obj);

        }


    }
}
