namespace OnlineLearningPlatformGroup5.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int InstructorID { get; set; }

        //public User Instructor { get; set; }
        
        public string Category { get; set; }

        public int EnrollmentCount { get; set; }

        public string ImageURL { get; set; }
    }
}
