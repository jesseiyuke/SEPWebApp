using SEP.DataAccess.Repository.IRepository;
using SEP.Models;

namespace SEP.DataAccess.Repository
{
    public class QualificationRepository : Repository<Qualifications>, IQualificationRepository
    {
        private ApplicationDbContext _db;
        public QualificationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Qualifications obj)
        {
            _db.Qualifications.Update(obj);
        }
    }
}
