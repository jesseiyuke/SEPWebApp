using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SEP.DataAccess;
using SEP.DataAccess.Repository.IRepository;
using SEP.Models;

namespace SEPWebApp.Areas.Controllers
{
    [Area("Student")]
    public class StudentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult GetDepartmentsByFaculty(int facultyId)
        {
            // Retrieve departments based on the facultyId using the Unit of Work
            IEnumerable<Department> DepartmentList = _unitOfWork.Department.GetAll().Where(d => d.FacultyId == facultyId);

            ViewBag.Department = new SelectList(DepartmentList, "Id", "Name");
            return View();
        }

        public IActionResult Profile() 
        {
            IEnumerable<DriverLicense> DriverLicenceList = _unitOfWork.DriverLicence.GetAll();
            ViewBag.DriverLicense = new SelectList(DriverLicenceList, "Id", "Name");
            IEnumerable<Gender> GenderList = _unitOfWork.Gender.GetAll();
            ViewBag.Gender = new SelectList(GenderList,"Id","Name");
            IEnumerable<Race> RaceList= _unitOfWork.Race.GetAll();
            ViewBag.Race = new SelectList(RaceList, "Id", "Name");
            IEnumerable<Nationality> NationalityList = _unitOfWork.Nationality.GetAll();
            ViewBag.Nationality=new SelectList(NationalityList,"Id","Name");
            IEnumerable<YearOfStudy> YearOfStudyList= _unitOfWork.YearOfStudy.GetAll();
            ViewBag.YearOfStudy=new SelectList(YearOfStudyList,"Id","Name");
            IEnumerable<Department> DepartmentList = _unitOfWork.Department.GetAll().Where(d => d.FacultyId == 1);
            ViewBag.Department=new SelectList(DepartmentList,"Id","Name");
            IEnumerable<Faculty> FacutyList = _unitOfWork.Faculty.GetAll();
            ViewBag.Faculty=new SelectList(FacutyList,"Id","Name");
            return View();
        }
        public IActionResult History()
        {
            return View();
        }
        public IActionResult Apply()
        {
            return View();
        }
    }
}
