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
    }
}
