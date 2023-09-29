using Microsoft.AspNetCore.Mvc;
using OnlineLearningPlatformGroup5.Services;

namespace OnlineLearningPlatformGroup5.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService courseService;
        public CourseController(ICourseService courseService) { 
            this.courseService = courseService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
