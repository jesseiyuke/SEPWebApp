using Microsoft.EntityFrameworkCore;
using SEP.Models;

namespace SEP.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Employer> Employer { get; set; }
        public DbSet<JobPost> JobPost { get; set; }

        public DbSet<User> User { get; set; }
        public DbSet<Student>Student { get; set; }


        
    }
}
