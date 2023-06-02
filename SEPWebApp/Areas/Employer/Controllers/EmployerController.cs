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
            Employer employer = _unitOfWork.Employer.GetFirstOrDefault(e => e.Id == EmployerId);

/*            if(employer==null)
            {
                employer.Id=user.Id; //Manually set Employer Id
            }*/

            EmployerVM employerVM = new EmployerVM();

            employerVM.Employer = employer;


            return View(employerVM);

        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(EmployerVM obj)
        {

            if (ModelState.IsValid)
            {

                if (obj.Employer.Id == null)
                {
/*                    var EmployerId = _userManager.GetUserId(User);
                    ApplicationUser user = _unitOfWork.ApplicationUser.GetFirstOrDefault(u => u.Id == EmployerId);
                    Employer employer = _unitOfWork.Employer.GetFirstOrDefault(e => e.Id == EmployerId);
                    employer.Id = user.Id; //Manually set Employer Id*/
                    _unitOfWork.Employer.Add(obj.Employer);
                }
                else
                {
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
