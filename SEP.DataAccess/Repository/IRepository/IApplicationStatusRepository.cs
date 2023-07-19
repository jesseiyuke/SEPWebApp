using SEP.Models;

namespace SEP.DataAccess.Repository.IRepository
{
    public interface IApplicationStatusRepository : IRepository<ApplicationStatus>
    {
        void Update(ApplicationStatus obj);
    }
}
