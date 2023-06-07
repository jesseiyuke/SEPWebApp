using SEP.DataAccess.Repository.IRepository;
using SEP.Models;

namespace SEP.DataAccess.Repository
{
    public class RefeeresRepository : Repository<Referees>, IRefereesRepository
    {
        private ApplicationDbContext _db;
        public RefeeresRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Referees obj)
        {
            _db.Referees.Update(obj);
        }
    }
}
