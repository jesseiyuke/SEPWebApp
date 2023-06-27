using SEP.Models;

namespace SEP.DataAccess.Repository.IRepository
{
    public interface IStudentApplicationRepository : IRepository<StudentApplication>
    {
        void Update(StudentApplication obj);
        StudentApplication Get(int id);
    }
}
