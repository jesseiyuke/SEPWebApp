using SEP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP.DataAccess.Repository.IRepository
{
    public interface IApplicationDocumentRepository : IRepository<ApplicationDocument>
    {
        void Update(ApplicationDocument obj);
        IEnumerable<ApplicationDocument> GetApplicationDocument(int id);
    }
}
