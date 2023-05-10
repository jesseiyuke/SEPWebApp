using Microsoft.AspNetCore.Mvc;
using SEPWebApp.Data;
using SEPWebApp.Models;

namespace SEPWebApp.Controllers
{
    public class JobPostController : Controller
    {
        private readonly ApplicationDbContext _db;

        public JobPostController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<JobPost> objJobPostList = _db.JobPost;
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
                _db.JobPost.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);



        }

    }
}
