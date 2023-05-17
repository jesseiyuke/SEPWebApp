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
    }
}
