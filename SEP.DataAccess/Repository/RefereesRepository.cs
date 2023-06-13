using Microsoft.EntityFrameworkCore;
using SEP.DataAccess.Repository.IRepository;
using SEP.Models;
using System.Linq.Expressions;

namespace SEP.DataAccess.Repository
{
    public class RefeeresRepository : Repository<Referees>, IRefereesRepository
    {
        private ApplicationDbContext _db;
        public RefeeresRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public IEnumerable<Referees> GetByUserId(string userId)
        {
            IEnumerable<Referees> referees= _db.Referees.Where(d => d.StudentId == userId);
            return referees;
        }

        public void Update(Referees obj)
        {
            _db.Referees.Update(obj);
        }
    }
}
