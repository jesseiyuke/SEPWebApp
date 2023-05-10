using Microsoft.EntityFrameworkCore;
using SEP.Models;

namespace SEP.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<JobPost> JobPost { get; set; }
    }
}
