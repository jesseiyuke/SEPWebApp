using Microsoft.AspNetCore.Mvc;
using SEP.DataAccess.Repository.IRepository;
using SEP.Models;

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
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(JobPost obj)
        {
            if (obj.JobDescription == obj.KeyResponsibilities)
            {
                ModelState.AddModelError("JobDescription", "Description of job cannot exactly match the Key responsibilities.");
            }

            if (ModelState.IsValid)
            {
                _unitOfWork.JobPost.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Job post created successfully";
                return RedirectToAction("Index");
            }
            return View(obj);

        }


        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            //var JobPostFromDb = _db.JobPost.Find(id);
            var JobPostFromDbFirst = _unitOfWork.JobPost.GetFirstOrDefault(u => u.Id == id);

            if (JobPostFromDbFirst == null)
            {
                return NotFound();
            }

            return View(JobPostFromDbFirst);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(JobPost obj)
        {
            if (obj.JobDescription == obj.KeyResponsibilities)
            {
                ModelState.AddModelError("JobDescription", "Description of job cannot exactly match the Key responsibilities.");
            }

            if (ModelState.IsValid)
            {
                _unitOfWork.JobPost.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Job post updated successfully";
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
