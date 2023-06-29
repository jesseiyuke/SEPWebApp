using LinqKit;
using Microsoft.EntityFrameworkCore;
using SEP.DataAccess.Repository.IRepository;
using SEP.Models;

namespace SEP.DataAccess.Repository
{
    public class JobPostRepository : Repository<JobPost>, IJobPostRepository
    {
        private ApplicationDbContext _db;
        public JobPostRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(JobPost obj)
        {
            _db.JobPost.Update(obj);
        }

        public IEnumerable<StudentApplication> GetApplyJobPost(string userId)
        {
            IEnumerable<StudentApplication> studentApplication = _db.StudentApplication
                .Where(d => d.StudentId == userId)
                .Include(a=>a.applicationStatus)
                .Include(a => a.jobPost).ThenInclude(a => a.Department)
                .Include(a => a.jobPost).ThenInclude(a => a.WeekHour);
            return studentApplication;
        }
        public IEnumerable<JobPost> GetJobPosts(Student student)
        {
            var predicate = PredicateBuilder.New<JobPost>();
            predicate = predicate.And(p => p.StatusId==2);
            //filter if student is not a south african citizen
            if (student.NationalityId==2)
            {
                predicate = predicate.And(p => p.OpenTo== "Open to everyone");
            }

            int YearOfStudy = student.YearOfStudyId;
            switch (YearOfStudy)
            {
                case 1:
                    predicate = predicate.And(p => p.FirstYear);
                    break;
                case 2:
                    predicate = predicate.And(p => p.SecondYear);
                    break;
                case 3:
                    predicate = predicate.And(p => p.ThirdYear);
                    break;
                case 4:
                    predicate = predicate.And(p => p.Honours);
                    break;
                case 5:
                    predicate = predicate.And(p => p.Graduates);
                    break;
                case 6:
                    predicate = predicate.And(p => p.Masters);
                    break;
                case 7:
                    predicate = predicate.And(p => p.PhD);
                    break;
                case 8:
                    predicate = predicate.And(p => p.Postdoc);
                    break;
            }
            predicate = predicate.Or(p => /*p.isApproved &&*/ p.StatusId==2 && !p.FirstYear && !p.SecondYear && !p.ThirdYear && !p.Honours && !p.Graduates && !p.Masters && !p.PhD && !p.Postdoc);


            //filter out job posts that have already been applied to
            var postsAppliedToIds = _db.StudentApplication.Where(a => a.StudentId == student.Id).Select(a => a.JobPostId);

            var posts = _db.JobPost.Where(predicate).ToList();
            posts = posts.Where(p => !postsAppliedToIds.Contains(p.Id)).ToList();
            return posts;
        }
        public JobPost GetJobPost(int? id)
        {
            JobPost jobPost=_db.JobPost
                .Include(a => a.JobType)
                .Include(a => a.WeekHour)
                .Include(a => a.Department).FirstOrDefault(a=>a.Id==id);
            return jobPost;
        }
    }
}
