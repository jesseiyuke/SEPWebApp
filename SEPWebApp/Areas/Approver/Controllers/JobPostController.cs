﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SEP.DataAccess;
using SEP.DataAccess.Repository.IRepository;
using SEP.Models;
using SEP.Models.ViewModels;
using SEP.Utility;
using System.Data;
using System.Drawing;

namespace SEPWebApp.Areas.Approver.Controllers
{
    [Area("Approver")]
    [Authorize(Roles = SD.Role_Approver)]
    public class JobPostController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ApplicationDbContext _db;

        public JobPostController(IUnitOfWork unitOfWork, ApplicationDbContext applicationDbContext)
        {
            _unitOfWork = unitOfWork;
            _db = applicationDbContext;
        }
        public IActionResult Index()
        {
            /*            IEnumerable<JobPost> objJobPostList = _unitOfWork.JobPost.GetAll();
                        return View(objJobPostList);*/
            return View();
        }

        public JsonResult GetFaculties()
        {
            var faculties = _unitOfWork.Faculty.GetAll();

            return new JsonResult(faculties);
        }

        public JsonResult GetDepartments(int id)
        {
            var departments = _unitOfWork.Department.GetAll().Where(d => d.FacultyId == id);

            return new JsonResult(departments);
        }

        //GET
        public IActionResult Upsert(int? id)
        {
            //
            JobPostVM JobPostVM = new()
            {
                JobPost = new(),
                JobTypeList = _unitOfWork.JobType.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString(),
                }),
                WeekHourList = _unitOfWork.WeekHour.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),
                StatusList = _unitOfWork.Status.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),
            };

            if (id == null || id == 0)
            {
                //create JobPost
                IEnumerable<Faculty> faculties = _db.Faculty;

                JobPostVM.FacultyList = faculties;

                IEnumerable<Department> departments = _db.Department;

                JobPostVM.DepartmentList = departments;
                return View(JobPostVM);
            }
            else
            {
                //update JobPost
                JobPostVM.JobPost = _unitOfWork.JobPost.GetFirstOrDefault(u => u.Id == id);

                IEnumerable<Faculty> faculties = _db.Faculty;

                JobPostVM.FacultyList = faculties;

                IEnumerable<Department> departments = _db.Department.Where(d => d.FacultyId == JobPostVM.JobPost.FacultyId);

                JobPostVM.DepartmentList = departments;
                return View(JobPostVM);

            }

        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(JobPostVM obj)
        {
            /*            if (obj.JobDescription == obj.KeyResponsibilities)
                        {
                            ModelState.AddModelError("JobDescription", "Description of job cannot exactly match the Key responsibilities.");
                        }*/

            if (ModelState.IsValid)
            {
                if (obj.JobPost.Id == 0)
                {
                    _unitOfWork.JobPost.Add(obj.JobPost);
                }
                else
                {
                    _unitOfWork.JobPost.Update(obj.JobPost);
                }
                _unitOfWork.Save();
                TempData["success"] = "Job Post status updated";
                return RedirectToAction("Index");
            }
            return View(obj);

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

        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var JobPostFromDbFirst = _unitOfWork.JobPost.GetFirstOrDefault(u => u.Id == id);

            if (JobPostFromDbFirst == null)
            {
                return NotFound();
            }

            return View(JobPostFromDbFirst);
        }

        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _unitOfWork.JobPost.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            _unitOfWork.JobPost.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Job Post deleted successfully";
            return RedirectToAction("Index");

        }

    }
}
