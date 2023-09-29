using OnlineLearningPlatformGroup5.Models;

namespace OnlineLearningPlatformGroup5.Services
{
    public interface IUserService
    {
        void Create(Course course);
        void Update(int id, Course course);
        List<Course> GetAll();
        Course Get(int id);
        void Delete(int id);
    }
}
