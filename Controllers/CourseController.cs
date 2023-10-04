using Microsoft.AspNetCore.Mvc;
using OnlineLearningPlatformGroup5.Data;

namespace OnlineLearningPlatformGroup5.Controllers
{
    public class CourseController : Controller
    {
        //Reach out the database to take data
        private readonly DatabaseContext _context;
        public CourseController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var list = _context.Course.ToList();
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
