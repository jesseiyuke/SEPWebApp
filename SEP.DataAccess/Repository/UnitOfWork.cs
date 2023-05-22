using SEP.DataAccess.Repository.IRepository;

namespace SEP.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            JobPost = new JobPostRepository(_db);
            Employer = new EmployerRepository(_db);
        }

        public IJobPostRepository JobPost { get; private set; }
        public IEmployerRepository Employer { get; private set; }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
