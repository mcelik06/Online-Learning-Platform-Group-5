using Microsoft.EntityFrameworkCore;

namespace SampleMonitoringProj.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> opts) : base(opts) { }

        public DbSet<Course> courses { get; set; }
        public DbSet<User> users { get; set; }

    }
}
