using SEP.DataAccess.Repository.IRepository;
using SEP.Models;

namespace SEP.DataAccess.Repository
{
    public class EmployerRepository : Repository<Employer>, IEmployerRepository
    {
        private ApplicationDbContext _db;
        public EmployerRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Employer obj)
        {
            _db.Employer.Update(obj);
        }
    }
}
