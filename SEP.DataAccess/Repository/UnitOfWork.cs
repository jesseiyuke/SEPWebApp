using SEP.DataAccess.Repository.IRepository;

namespace SEP.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            JobPost = new JobPostRepository(_db);
            Employer = new EmployerRepository(_db);
            DriverLicence = new DriverLicenseRepository(_db);
            Gender = new GenderRepository(_db);
            Race = new RaceRepository(_db);
            Nationality = new NationalityRepository(_db);
            YearOfStudy = new YearOfStudyRepository(_db);
            Department = new DepartmentRepository(_db);
            Faculty = new FacultyRepository(_db);

            JobType = new JobTypeRepository(_db);
            WeekHour = new WeekHourRepository(_db);
            Status = new StatusRepository(_db);
        }

        public IJobPostRepository JobPost { get; private set; }
        public IEmployerRepository Employer { get; private set; }
        public IDriverLicenseRepository DriverLicence { get; private set; }
        public IGenderRepository Gender { get; private set; }
        public IRaceRepository Race { get; private set; }
        public INationalityRepository Nationality { get; private set; }
        public IYearOfStudyRepository YearOfStudy { get; private set; }
        public IDepartmentRepository Department { get; private set; }
        public IFacultyRepository Faculty { get; private set; }

        public IJobTypeRepository JobType { get; private set; }
        public IWeekHourRepository WeekHour { get; private set; }
        public IStatusRepository Status { get; private set; }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
