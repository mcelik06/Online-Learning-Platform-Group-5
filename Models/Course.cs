namespace OnlineLearningPlatformGroup5.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
        public string EnrollmentCount { get; set; }

        //Foreign Key A Course can be given by ONE User
        public User Instructor { get; set; }


        //Foreign Key A Course can contain MANY Assignments
        public ICollection<Assignment> Assignments { get; }

        //Foreign Key A Course can contaion MANY Enrollments
        //Since we are connected two different table as MANY relation into one table, we need to change the
        // migration file. On the forign key attributes, Ondelete property should be no action. We will change this by hand.
        public ICollection<Enrollment> Enrollments { get; }

    }
}
