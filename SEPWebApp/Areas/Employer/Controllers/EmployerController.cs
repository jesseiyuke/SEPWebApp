using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SEP.DataAccess.Repository.IRepository;
using SEP.Models;
using SEP.Models.ViewModels;

namespace SEPWebApp.Controllers
{
    [Area("Employer")]
    public class EmployerController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public EmployerController(IUnitOfWork unitOfWork, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        //GET
        public IActionResult Upsert()
        {
            EmployerVM EmployerVM = new()
            {
                ApplicationUser = new(),
                Employer = new()

            };
            var EmployerId = _userManager.GetUserId(User);
            ApplicationUser user = _unitOfWork.ApplicationUser.GetFirstOrDefault(u => u.Id == EmployerId);
            Employer employer = _unitOfWork.Employer.GetFirstOrDefault(e => e.ApplicationUserId == EmployerId);



            //create JobPost
            if (employer == null)
            {
                EmployerVM.ApplicationUser = _unitOfWork.ApplicationUser.GetFirstOrDefault(u => u.Id == EmployerId);
                return View(EmployerVM);
            }
            else
            {
                //update JobPost
                EmployerVM.ApplicationUser = _unitOfWork.ApplicationUser.GetFirstOrDefault(u => u.Id == EmployerId);
                EmployerVM.Employer = _unitOfWork.Employer.GetFirstOrDefault(u => u.ApplicationUserId == EmployerId);
                return View(EmployerVM);

            }

        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(EmployerVM obj)
        {

            var EmployerId = _userManager.GetUserId(User);
            ApplicationUser user = _unitOfWork.ApplicationUser.GetFirstOrDefault(u => u.Id == EmployerId);
            Employer employer = _unitOfWork.Employer.GetFirstOrDefault(e => e.ApplicationUserId == EmployerId);

            if (ModelState.IsValid)
            {

                if (employer == null)
                {
                    obj.Employer.ApplicationUserId = EmployerId;
                    _unitOfWork.Employer.Add(obj.Employer);
                }
                else
                {
                    obj.ApplicationUser = user;
                    obj.Employer.ApplicationUser = user;
                    _unitOfWork.Employer.Update(obj.Employer);
                }


                _unitOfWork.Save();
                TempData["success"] = "Profile updated successfully";
                return RedirectToAction("Index");
            }
            return View(obj);

        }


    }
}