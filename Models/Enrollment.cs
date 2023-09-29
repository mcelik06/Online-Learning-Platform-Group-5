using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineLearningPlatformGroup5.Models
{
    public class Enrollment
    {
        
        public int ID { get; set; }

        public int UserID { get; set; }

        //public User User { get; set;}
        //public ICollection<User> Users { get; }

        public int CourseID { get; set; }

        //public Course Course { get; set; }
        //public ICollection<Course> Courses { get; }


        public string DueDate { get; set; }



    }
}
