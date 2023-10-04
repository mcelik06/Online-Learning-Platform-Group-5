using OnlineLearningPlatformGroup5.Models;

namespace OnlineLearningPlatformGroup5.Services
{
    public interface IUserService
    {
        void Create(User user);
        void Update(User user);
        void Delete(int id);
        User Read(int id);
        List<User> ReadAll();
    }
}
