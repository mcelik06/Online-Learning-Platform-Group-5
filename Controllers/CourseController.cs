using Microsoft.AspNetCore.Mvc;
using SampleMonitoringProj.Services;

namespace SampleMonitoringProj.Controllers
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
