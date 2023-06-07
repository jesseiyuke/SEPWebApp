using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SEP.DataAccess.Repository.IRepository;
using SEP.Models;
using SEP.Models.ViewModels;
using SEP.Utility;
using System.Data;

namespace SEPWebApp.Areas.Employer.Controllers
{
    [Area("Approver")]
    [Authorize(Roles = SD.Role_Approver)]
    public class ApproverController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ApproverController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ReviewExternalEmployers()
        {
            return View();
        }

        public IActionResult ReviewPosts()
        {
            return View();
        }
        public IActionResult Stats()
        {
            return View();
        }

    }
}
