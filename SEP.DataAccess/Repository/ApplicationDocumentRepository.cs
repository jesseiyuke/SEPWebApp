using SEP.DataAccess.Repository.IRepository;
using SEP.Models;
using System.Reflection.Metadata.Ecma335;

namespace SEP.DataAccess.Repository
{
    public class ApplicationDocumentRepository : Repository<ApplicationDocument>, IApplicationDocumentRepository
    {
        private ApplicationDbContext _db;
        public ApplicationDocumentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(ApplicationDocument obj)
        {
            _db.ApplicationDocument.Update(obj);
        }
        public IEnumerable<ApplicationDocument> GetApplicationDocument(int id) {
            IEnumerable<ApplicationDocument> documents = _db.ApplicationDocument.Where(a => a.ApplicationId == id).ToList();
            return documents;
        }
    }
}
