using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ElevateProjectFinal.Models
{
    public class DatabaseContext : IdentityDbContext<IdentityUser>
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> opts) : base(opts) { }
        public DbSet<User> User { get; set; }
        /*public DbSet<Assignment> Assignment => Set<Assignment>();
        public DbSet<Enrollment> Enrollment => Set<Enrollment>();
        public DbSet<Course> Course => Set<Course>();*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().Property(u => u.UserName).IsRequired();
        }

    }

}

