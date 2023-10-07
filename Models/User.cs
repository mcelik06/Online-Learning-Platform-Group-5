using Microsoft.AspNetCore.Identity;

namespace OnlineLearningPlatformGroup5.Models
{
    public class User : IdentityUser
    {
        //Some properties are removed since we are using .net identityUser Table

        //public int Id { get; set; }
        //public string UserName { get; set; }
        //public string Password { get; set; }
        //public string Email { get; set; }
        //public string Role { get; set; }

        //Foreign Key A User can take MANY Courses
        public ICollection<Course> Courses { get; }

        //Foreign Key A User can enroll MANY times
        public ICollection<Enrollment> Enrollments { get; }

    }
}
