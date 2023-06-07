using SEP.DataAccess.Repository.IRepository;
using SEP.Models;

namespace SEP.DataAccess.Repository
{
    public class ExperienceRepository : Repository<Experience>, IExperienceRepository
    {
        private ApplicationDbContext _db;
        public ExperienceRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Experience obj)
        {
            _db.Experience.Update(obj);
        }
    }
}
