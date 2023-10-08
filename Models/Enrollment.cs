using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineLearningPlatformGroup5.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        //Foreign Key AN Enrollment can be done by ONE User
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        //Foreign Key AN Enrollment can be done to ONE Course
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; }


        public string EnrollmentDate { set; get; }

    }
}
