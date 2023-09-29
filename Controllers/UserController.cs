using Microsoft.AspNetCore.Mvc;

namespace OnlineLearningPlatformGroup5.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
