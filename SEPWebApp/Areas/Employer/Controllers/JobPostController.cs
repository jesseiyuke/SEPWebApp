using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SEP.DataAccess.Repository.IRepository;
using SEP.Models;
using SEP.Models.ViewModels;

namespace SEPWebApp.Areas.Employer.Controllers
{
    [Area("Employer")]
    public class JobPostController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public JobPostController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<JobPost> objJobPostList = _unitOfWork.JobPost.GetAll();
            return View(objJobPostList);
        }

        //GET
        public IActionResult Upsert(int? id)
        {
            //
            JobPostVM JobPostVM = new()
            {
                JobPost = new(),
                //All drop down lists from ViewModel
                FacultyList = _unitOfWork.Faculty.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),
                DepartmentList = _unitOfWork.Department.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),
                JobTypeList = _unitOfWork.JobType.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
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
                return View(JobPostVM);
            }
            else
            {
                //update JobPost
                JobPostVM.JobPost = _unitOfWork.JobPost.GetFirstOrDefault(u => u.Id == id);
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
                TempData["success"] = "Job Post created successfully";
                return RedirectToAction("Index");
            }
            return View(obj);

        }

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
