namespace OnlineLearningPlatformGroup5.Models
{
    public class Enrollment
    {
        public int Id { get; set; }

        //Foreign Key AN Enrollment can be done by ONE User
        public User User { get; set; }

        //Foreign Key AN Enrollment can be done to ONE Course
        public Course Course { get; set; }


        public string EnrollmentDate { set; get; }

    }
}
