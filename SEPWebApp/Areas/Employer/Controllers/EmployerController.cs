using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
                Employer = new(),
                BusinessTypeList = _unitOfWork.BusinessType.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),

            };
            var EmployerId = _userManager.GetUserId(User);
            ApplicationUser user = _unitOfWork.ApplicationUser.GetFirstOrDefault(u => u.Id == EmployerId);
            Employer employer = _unitOfWork.Employer.GetFirstOrDefault(e => e.Id == EmployerId);



            //create Employer
            if (employer == null)
            {
                EmployerVM.ApplicationUser = _unitOfWork.ApplicationUser.GetFirstOrDefault(u => u.Id == EmployerId);
                return View(EmployerVM);
            }
            else
            {
                //update Employer
                EmployerVM.ApplicationUser = _unitOfWork.ApplicationUser.GetFirstOrDefault(u => u.Id == EmployerId);
                EmployerVM.Employer = _unitOfWork.Employer.GetFirstOrDefault(u => u.Id == EmployerId);
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
            Employer employer = _unitOfWork.Employer.GetFirstOrDefault(e => e.Id == EmployerId);


            if (ModelState.IsValid)
            {

                if (employer == null)
                {
                    obj.Employer.Id = EmployerId;
                    _unitOfWork.Employer.Add(obj.Employer);
                }
                else
                {
                    //obj.ApplicationUser = user;
                    obj.Employer.ApplicationUser = user;
                    //obj.BusinessTypeList
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