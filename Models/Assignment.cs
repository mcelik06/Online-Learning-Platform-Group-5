using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineLearningPlatformGroup5.Models
{
    public class Assignment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //Foreign Key AN Assignment can belong to ONE Course
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public Course Course { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }


    }
}
