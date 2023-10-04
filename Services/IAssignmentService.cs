using OnlineLearningPlatformGroup5.Models;

namespace OnlineLearningPlatformGroup5.Services
{
    public interface IAssignmentService
    {
        void Create(Assignment assignment);
        void Update(Assignment assignment);
        void Delete(int id);
        Assignment Read(int id);
        List<Assignment> ReadAll();

    }
}
