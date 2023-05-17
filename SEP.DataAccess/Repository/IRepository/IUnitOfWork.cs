namespace SEP.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IJobPostRepository JobPost { get; }
        void Save();
    }
}
