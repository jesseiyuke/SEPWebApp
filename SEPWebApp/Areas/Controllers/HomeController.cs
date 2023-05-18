using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Scripting;
using SEP.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Identity;

namespace SEPWebApp.Areas.Controllers
{
    [Area("Employer")]
    public class HomeController : Controller
    {

        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _signInManager = signInManager;
            _userManager = userManager;

        }

        public async Task<IActionResult> IndexAsync()
        {

            if (_signInManager.IsSignedIn(User))
            {

                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                var roles = await _userManager.GetRolesAsync(user);
                foreach (var role in roles)
                {



                }
            }
            else
            {

                return RedirectToAction("Login", "Identity");

            }

            return View();
        }
        public IActionResult Studentlogin()
        {
            return RedirectToAction("Index", "Student");
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