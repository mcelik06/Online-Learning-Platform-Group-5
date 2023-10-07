using Microsoft.AspNetCore.Mvc;

namespace OnlineLearningPlatformGroup5.Controllers
{
    public class EnrollmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
