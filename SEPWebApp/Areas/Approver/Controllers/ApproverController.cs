using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SEP.DataAccess.Data;
using SEP.DataAccess.Repository.IRepository;
using SEP.Models;
using SEP.Models.ViewModels;
using SEP.Utility;
using SmartBreadcrumbs.Attributes;

namespace SEPWebApp.Areas.Approver.Controllers
{
    [Area("Approver")]
    [Authorize(Roles = SD.Role_Approver)]
    public class ApproverController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly FakeJobPost _fakeJobPost;

        public ApproverController(IUnitOfWork unitOfWork, FakeJobPost fakeJobPost)
        {
            _unitOfWork = unitOfWork;
            _fakeJobPost = fakeJobPost;
        }
        //[DefaultBreadcrumb("Home", AreaName = "Approver")]
        [Breadcrumb("Approver", AreaName = "Approver")]
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
        [Breadcrumb("Stats", FromAction = "Index")]
        public IActionResult Stats()
        {
            return View();
        }

        public IActionResult PlotJobPost()
        {

            var fakeDataGenerator = new FakeJobPost();
            var jobs = _fakeJobPost.GenerateFakePost(50);
            foreach (FakePost fakeJob in jobs)
            {
                Department department = _unitOfWork.Department.GetFirstOrDefault(s => s.Id == fakeJob.DepartmentId);
                fakeJob.Department = department;
                WeekHour hour = _unitOfWork.WeekHour.GetFirstOrDefault(s => s.Id == fakeJob.HoursId);
                fakeJob.Hours = hour;
            }

            Dictionary<string, decimal> rateByDepartment = fakeDataGenerator.GetAverageRateByDepartment(jobs);

            Dictionary<string, decimal> rateByWeekHour = fakeDataGenerator.GetAverageRateByWeekHour(jobs);

            ViewBag.DepartmentNames = rateByDepartment.Keys.ToArray();
            ViewBag.DepartmentRates = rateByDepartment.Values.ToArray();
            ViewBag.WeekHours = rateByWeekHour.Keys.ToArray();
            ViewBag.WeekHourRates = rateByWeekHour.Values.ToArray();
            return View();
        }

    }
}
