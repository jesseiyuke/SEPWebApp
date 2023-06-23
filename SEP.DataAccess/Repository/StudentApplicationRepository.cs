using SEP.DataAccess.Repository.IRepository;
using SEP.Models;
namespace SEP.DataAccess.Repository
{
    public class StudentApplicationRepository : Repository<StudentApplication>, IStudentApplicationRepository
    {
        private ApplicationDbContext _db;
        public StudentApplicationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(StudentApplication obj)
        {
            _db.StudentApplication.Update(obj);
        }
    }
}
