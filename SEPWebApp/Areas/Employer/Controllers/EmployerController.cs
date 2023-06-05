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

            var EmployerId = _userManager.GetUserId(User);
            ApplicationUser user = _unitOfWork.ApplicationUser.GetFirstOrDefault(u => u.Id == EmployerId);
            Employer employer = _unitOfWork.Employer.GetFirstOrDefault(e => e.ApplicationUserId == EmployerId);

            EmployerVM employerVM = new EmployerVM();

            if (employer == null) //Create Employer
            {

                employer = new Employer();
                employer.ApplicationUser = user;
                employerVM.Title = employer.ApplicationUser.Title;
                employerVM.FirstName = employer.ApplicationUser.FirstName;
                employerVM.LastName = employer.ApplicationUser.LastName;
                employerVM.Telephone = employer.ApplicationUser.Telephone;
            }
            else //Edit Employer
            {
                employer.ApplicationUser = user;
                employerVM.Title = employer.ApplicationUser.Title;
                employerVM.FirstName = employer.ApplicationUser.FirstName;
                employerVM.LastName = employer.ApplicationUser.LastName;
                employerVM.Telephone = employer.ApplicationUser.Telephone;

                employerVM.JobTitle = employer.JobTitle;
                employerVM.CompanyRegNo = employer.CompanyRegNo;
                employerVM.BusinessName = employer.BusinessName;
                employerVM.TradingName = employer.TradingName;
                employerVM.BusinessType = employer.BusinessType;
                employerVM.RegisteredAddress = employer.RegisteredAddress;

            }

            return View(employerVM);

        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpsertProfile(EmployerVM employer)
        {

            var EmployerId = _userManager.GetUserId(User);
            ApplicationUser user = _unitOfWork.ApplicationUser.GetFirstOrDefault(u => u.Id == EmployerId);
            Employer employerVM = _unitOfWork.Employer.GetFirstOrDefault(e => e.Id == EmployerId);

            if (ModelState.IsValid)
            {
                if (employerVM == null)
                {
                    employerVM= new Employer();
                }
                employerVM.ApplicationUser = user;
                employerVM.JobTitle = employer.JobTitle;
                employerVM.CompanyRegNo = employer.CompanyRegNo;
                employerVM.BusinessName = employer.BusinessName;
                employerVM.TradingName = employer.TradingName;
                employerVM.BusinessType = employer.BusinessType;
                employerVM.RegisteredAddress = employer.RegisteredAddress;

                _unitOfWork.Employer.Update(employerVM);
                _unitOfWork.Save();
                TempData["success"] = "Profile updated successfully";
                return RedirectToAction("Index");
            }
            return View(employer);

        }


    }
}
