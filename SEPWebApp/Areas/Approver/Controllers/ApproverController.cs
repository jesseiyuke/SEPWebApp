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

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var JobPostList = _unitOfWork.JobPost.GetAll(includeProperties: "Faculty,Department,JobType,WeekHour,Status");
            //var JobPostList = _unitOfWork.JobPost.GetAll();
            return Json(new { data = JobPostList });
        }
        #endregion

    }
}
