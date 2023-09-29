using Microsoft.EntityFrameworkCore;

namespace OnlineLearningPlatformGroup5.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> opts) : base(opts) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

    }
}
