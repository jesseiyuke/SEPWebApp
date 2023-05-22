namespace SEP.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IJobPostRepository JobPost { get; }
        IEmployerRepository Employer { get; }

        void Save();
    }
}
