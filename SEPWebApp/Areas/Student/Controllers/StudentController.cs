using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SEP.DataAccess;
using SEP.DataAccess.Repository.IRepository;
using SEP.Models;
using SEP.Models.ViewModels;
using SEP.Utility;
using SEPWebApp.Areas.Home.Controllers;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Security.Cryptography;

namespace SEPWebApp.Areas.Controllers
{
    [Area("Student")]
    [Authorize(Roles = SD.Role_Student)]
    public class StudentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<IdentityUser> _userManager;
        private ApplicationDbContext _db;

        public StudentController(IUnitOfWork unitOfWork, ILogger<HomeController> logger, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, ApplicationDbContext db)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _db = db;
        }

        public IActionResult Index()
        {

            var studentID = _userManager.GetUserId(User);
            Student student = _unitOfWork.Student.GetFirstOrDefault(d => d.Id == studentID);
            if (student == null)
            {
                return RedirectToAction("AddStudent", "Student", new { area = "Student" });
            }
            return View();
        }

        public IActionResult AddStudent()
        {

            var studentID = _userManager.GetUserId(User);
            Student student = _unitOfWork.Student.GetFirstOrDefault(d => d.Id == studentID);
            ApplicationUser user = _unitOfWork.ApplicationUser.GetFirstOrDefault(x => x.Id == studentID);
            StudentVM studentVM = new StudentVM();
            student = new Student();
            student.ApplicationUser = user;
            studentVM.Title = student.ApplicationUser.Title;
            studentVM.Telephone = student.ApplicationUser.Telephone;
            studentVM.cellPhone = student.ApplicationUser.PhoneNumber;
            studentVM.Email = student.ApplicationUser.Email;
            studentVM.FirstName = student.ApplicationUser.FirstName;
            studentVM.LastName = student.ApplicationUser.LastName;
            studentVM.DriverLicenceList = _unitOfWork.DriverLicence.GetAll().Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
            studentVM.GenderList = _unitOfWork.Gender.GetAll().Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
            studentVM.RaceList = _unitOfWork.Race.GetAll().Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
            studentVM.NationalityList = _unitOfWork.Nationality.GetAll().Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
            studentVM.YearOfStudyList = _unitOfWork.YearOfStudy.GetAll().Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
            studentVM.FacutyList = _unitOfWork.Faculty.GetAll().Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
            studentVM.DepartmentList = _unitOfWork.Department.GetAll().Where(d => d.FacultyId == 1).Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });

            return View(studentVM);
        }

        public IActionResult EditStudent(StudentVM student)
        {
            var studentID = _userManager.GetUserId(User);
            ApplicationUser user = _unitOfWork.ApplicationUser.GetFirstOrDefault(x => x.Id == studentID);
            Student studentVM = new Student();
            studentVM.ApplicationUser = user;
            studentVM.Achivements = student.Achivements;
            studentVM.Address = student.Address;
            studentVM.RaceId = (int)student.Race;
            studentVM.GenderId = (int)student.Gender;
            studentVM.IdNo = student.IdNo;
            studentVM.Interests = student.Interests;
            studentVM.ApplicationUser.Telephone = student.Telephone;
            studentVM.CareerObjective = student.CareerObjective;
            studentVM.DriversLicenseId = (int)student.DriversLicense;
            studentVM.YearOfStudyId = (int)student.YearOfStudy;
            studentVM.DepartmentId = (int)student.Department;
            studentVM.Skills = student.Skills;
            studentVM.NationalityId = (int)student.Nationality;
            studentVM.Interests = student.Interests;
            studentVM.ApplicationUser.PhoneNumber = student.cellPhone;

            _unitOfWork.Student.Add(studentVM);
            _unitOfWork.Save();
            TempData["success"] = "Student update successfull";
            return RedirectToAction("Index");

        }

        public JsonResult GetDepartments(int facultyId)
        {
            var departments = _unitOfWork.Department.GetAll().Where(d => d.FacultyId == facultyId);

            return Json(departments);
        }

        public IActionResult Profile()
        {

            var studentId = _userManager.GetUserId(User);
            Student student = _unitOfWork.Student.GetFirstOrDefault(d => d.Id == studentId);
            ApplicationUser user = _unitOfWork.ApplicationUser.GetFirstOrDefault(x => x.Id == studentId);
            StudentVM studentVM = new StudentVM();

            Department department = _unitOfWork.Department.GetFirstOrDefault(d => d.Id == student.DepartmentId);
            student.ApplicationUser = user;
            // studentVM =student;
            studentVM.Address = student.Address;
            studentVM.Race = student.RaceId;
            studentVM.Gender = student.GenderId;
            studentVM.cellPhone = student.ApplicationUser.PhoneNumber;
            studentVM.Email = student.ApplicationUser.Email;
            studentVM.FirstName = student.ApplicationUser.FirstName;
            studentVM.LastName = student.ApplicationUser.LastName;
            studentVM.IdNo = student.IdNo;
            studentVM.Interests = student.Interests;
            studentVM.Title = student.ApplicationUser.Title;
            studentVM.Telephone = student.ApplicationUser.Telephone;
            studentVM.CareerObjective = student.CareerObjective;
            studentVM.DriversLicense = student.DriversLicenseId;
            studentVM.YearOfStudy = student.YearOfStudyId;
            studentVM.Department = student.DepartmentId;
            studentVM.Skills = student.Skills;
            studentVM.Nationality = student.NationalityId;
            studentVM.Interests = student.Interests;
            studentVM.Faculty = department.FacultyId;

            studentVM.DriverLicenceList = _unitOfWork.DriverLicence.GetAll().Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
            studentVM.GenderList = _unitOfWork.Gender.GetAll().Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
            studentVM.RaceList = _unitOfWork.Race.GetAll().Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
            studentVM.NationalityList = _unitOfWork.Nationality.GetAll().Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
            studentVM.YearOfStudyList = _unitOfWork.YearOfStudy.GetAll().Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
            studentVM.FacutyList = _unitOfWork.Faculty.GetAll().Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
            studentVM.DepartmentList = _unitOfWork.Department.GetAll().Where(d => d.FacultyId == 1).Select(i => new SelectListItem
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
            studentVM.Referees = _unitOfWork.Referees.GetByUserId(studentId);
            studentVM.Qualification = _unitOfWork.Qualification.GetAll().Where(d => d.StudentId == studentId);
            studentVM.Experience = _unitOfWork.Experience.GetAll().Where(d => d.StudentId == studentId);
            IEnumerable<Referees> Referees = _unitOfWork.Referees.GetAll();

            return View(studentVM);
        }

        public IActionResult AddReferees(RefereeVM obj)
        {
            Referees referees = new Referees();
            var studentID = _userManager.GetUserId(User);
            Student student = _unitOfWork.Student.GetFirstOrDefault(d => d.Id == studentID);
            referees.StudentId = studentID;
            referees.Name = obj.Name;
            referees.Insitution = obj.Insitution;
            referees.Email = obj.Email;
            referees.Cell = obj.Cell;
            referees.JobTitle = obj.JobTitle;
            referees.Student = student;
            if (obj.Id == 0)
            {

                _unitOfWork.Referees.Add(referees);
                _unitOfWork.Save();
                TempData["success"] = "Referee added successfully";
                return RedirectToAction("Profile");

            }
            else
            {
                referees.Id = obj.Id;
                _unitOfWork.Referees.Update(referees);
                _unitOfWork.Save();
                TempData["success"] = "Referee added successfully";
                return RedirectToAction("Profile");
            }
        }
        public IActionResult AddExperince(Experience obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Experience.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Experience added successfully";
                return RedirectToAction("Profile");
            }
            return View(obj);
        }
        public IActionResult AddQualifications(Qualifications obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Qualification.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Qualification added successfully";
                return RedirectToAction("Profile");
            }
            return View(obj);
        }
        public IActionResult UpdateProfile(StudentVM student)
        {
            var studentID = _userManager.GetUserId(User);
            ApplicationUser user = _unitOfWork.ApplicationUser.GetFirstOrDefault(x => x.Id == studentID);
            Student studentVM = _unitOfWork.Student.GetFirstOrDefault(d => d.Id == studentID);

            studentVM.ApplicationUser = user;
            studentVM.Achivements = student.Achivements;
            studentVM.Address = student.Address;
            studentVM.RaceId = (int)student.Race;
            studentVM.GenderId = (int)student.Gender;
            studentVM.IdNo = student.IdNo;
            studentVM.Interests = student.Interests;
            studentVM.ApplicationUser.Telephone = student.Telephone;
            studentVM.CareerObjective = student.CareerObjective;
            studentVM.DriversLicenseId = (int)student.DriversLicense;
            studentVM.YearOfStudyId = (int)student.YearOfStudy;
            studentVM.DepartmentId = (int)student.Department;
            studentVM.Skills = student.Skills;
            studentVM.NationalityId = (int)student.Nationality;
            studentVM.Interests = student.Interests;
            studentVM.ApplicationUser.PhoneNumber = student.cellPhone;
            _unitOfWork.Student.Update(studentVM);
            _unitOfWork.Save();
            TempData["success"] = "Student   successfull";
            return RedirectToAction("Index");

        }


        public IActionResult Referees()
        {
            return View();
        }
        public IActionResult Education()
        {
            return View();
        }
        public IActionResult Employment()
        {
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
