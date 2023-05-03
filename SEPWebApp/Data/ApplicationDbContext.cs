using Microsoft.EntityFrameworkCore;
using SEPWebApp.Models;

namespace SEPWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Employer> Employers { get; set; }
    }
}
