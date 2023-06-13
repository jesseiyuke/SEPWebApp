using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SEP.DataAccess.Repository.IRepository;
using SEP.Utility;

namespace SEPWebApp.Areas.Approver.Controllers
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
        public IActionResult ReviewEmployers()
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
