using Microsoft.EntityFrameworkCore;
using SEP.DataAccess.Repository.IRepository;
using SEP.Models;

namespace SEP.DataAccess.Repository
{
    public class JobPostRepository : Repository<JobPost>, IJobPostRepository
    {
        private ApplicationDbContext _db;
        public JobPostRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(JobPost obj)
        {
            _db.JobPost.Update(obj);
        }

        public IEnumerable<StudentApplication> GetApplyJobPost(string userId)
        {
            IEnumerable<StudentApplication> studentApplication = _db.StudentApplication
                .Where(d => d.StudentId == userId)
                .Include(a=>a.applicationStatus)
                .Include(a => a.jobPost).ThenInclude(a => a.Department)
                .Include(a => a.jobPost).ThenInclude(a => a.WeekHour);
            return studentApplication;
        }
        public IEnumerable<JobPost> GetJobPosts(Student student)
        {
            IEnumerable<JobPost> posts = _db.JobPost
                .Include(a => a.JobType)
                .Include(a => a.WeekHour)
                .Include(a => a.Department);
            return posts;
        }
        public JobPost GetJobPost(int? id)
        {
            JobPost jobPost=_db.JobPost
                .Include(a => a.JobType)
                .Include(a => a.WeekHour)
                .Include(a => a.Department).FirstOrDefault(a=>a.Id==id);
            return jobPost;
        }
    }
}
