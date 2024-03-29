﻿using Microsoft.EntityFrameworkCore;
using SEP.DataAccess.Repository.IRepository;
using SEP.Models;
namespace SEP.DataAccess.Repository
{
    public class StudentApplicationRepository : Repository<StudentApplication>, IStudentApplicationRepository
    {
        private ApplicationDbContext _db;
        public StudentApplicationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(StudentApplication obj)
        {
            _db.StudentApplication.Update(obj);
        }
        public StudentApplication Get(int id)
        {
            StudentApplication studentApplication= _db.StudentApplication.Where(x => x.Id == id)
                .Include(a => a.Student).ThenInclude(a => a.ApplicationUser)
                .Include(a => a.Student).ThenInclude(a => a.Department.Faculty)
                .Include(a => a.Student).ThenInclude(a => a.Department)
                .Include(a => a.Student).ThenInclude(a => a.YearOfStudy)
                .Include(a => a.Student).ThenInclude(a => a.Gender)
                .Include(a => a.Student).ThenInclude(a => a.Nationality)
                .Include(a => a.jobPost).ThenInclude(a => a.JobType)
                .Include(a => a.jobPost).ThenInclude(a => a.WeekHour)
                .Include(a => a.applicationStatus)
                .FirstOrDefault(a=>a.Id==id);
            return (studentApplication);
        }
    }
}
