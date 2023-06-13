using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SEP.Models;
using System.Diagnostics;

namespace SEPWebApp.Areas.Home.Controllers
{
    [Area("Home")]
    public class HomeController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;


        public HomeController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public IActionResult Index()
        {

            if (_signInManager.IsSignedIn(User))
            {
                if (User.IsInRole("Approver"))
                {
                    return RedirectToAction("Index","Approver",new {area ="Approver"});
                }

                else if (User.IsInRole("Employer"))
                {
                    return RedirectToAction("Index", "Employer", new { area = "Employer" });
                }
                else
                {
                    return RedirectToAction("Index", "Student", new { area = "Student" });

                }
                
            }

            return RedirectToAction("Login", "Account", new { area = "Identity" });
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}