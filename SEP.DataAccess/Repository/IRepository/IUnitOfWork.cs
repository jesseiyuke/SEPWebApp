namespace SEP.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IJobPostRepository JobPost { get; }
        IEmployerRepository Employer { get; }
        IDriverLicenseRepository DriverLicence { get; }
        IGenderRepository Gender { get; }
        IRaceRepository Race { get; }
        INationalityRepository Nationality { get; }
        IYearOfStudyRepository YearOfStudy { get; }
        IDepartmentRepository Department { get; }
        IFacultyRepository Faculty { get; }

        IJobTypeRepository JobType { get; }
        IWeekHourRepository WeekHour { get; }
        IStatusRepository Status { get; }


        void Save();
    }
}
