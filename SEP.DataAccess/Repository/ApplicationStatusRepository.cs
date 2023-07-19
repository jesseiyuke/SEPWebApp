using SEP.DataAccess.Repository.IRepository;
using SEP.Models;

namespace SEP.DataAccess.Repository
{
    public class ApplicationStatusRepository : Repository<ApplicationStatus>, IApplicationStatusRepository
    {
        private ApplicationDbContext _db;
        public ApplicationStatusRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(ApplicationStatus obj)
        {
            _db.ApplicationStatus.Update(obj);
        }
    }
}
