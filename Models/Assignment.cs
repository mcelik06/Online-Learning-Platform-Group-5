namespace OnlineLearningPlatformGroup5.Models
{
    public class Assignment
    {
        public int Id { get; set; }

        //Foreign Key AN Assignment can belong to ONE Course
        public Course Course { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }



    }
}
