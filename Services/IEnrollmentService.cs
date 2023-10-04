using OnlineLearningPlatformGroup5.Models;

namespace OnlineLearningPlatformGroup5.Services
{
    public interface IEnrollmentService
    {
        void Create(Enrollment enrollment);
        void Update(Enrollment enrollment);
        void Delete(int id);
        Enrollment Read(int id);
        List<Enrollment> ReadAll();
    }
}
