using Microsoft.AspNetCore.Mvc;

namespace OnlineLearningPlatformGroup5.Controllers
{
    public class AssigmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
