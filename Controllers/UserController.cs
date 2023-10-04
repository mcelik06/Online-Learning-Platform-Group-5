using Microsoft.AspNetCore.Mvc;
using OnlineLearningPlatformGroup5.Data;
using OnlineLearningPlatformGroup5.Models;
using OnlineLearningPlatformGroup5.Services;

namespace OnlineLearningPlatformGroup5.Controllers
{
    public class UserController : Controller
    {
        private IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        public IActionResult Index()
        {   User user = new User();
            userService.Create(user);
            return View();
        }

    }
}
