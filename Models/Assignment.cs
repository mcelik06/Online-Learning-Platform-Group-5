namespace OnlineLearningPlatformGroup5.Models
{
    public class Assignment
    {
        public int ID { get; set; }

        public int CourseID { get; set; }

        //public Course Course { get; set; }
        //public ICollection<Course> Courses { get; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
    }
}
