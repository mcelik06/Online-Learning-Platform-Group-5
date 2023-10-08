using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineLearningPlatformGroup5.Data;
using OnlineLearningPlatformGroup5.Models;
using OnlineLearningPlatformGroup5.Utility;

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
            List<Course> courses = _context.Course.ToList();
            return View(courses);
        }

        [Authorize(Roles = SD.Role_Admin + "," + SD.Role_Instructor)]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = SD.Role_Admin + ","+ SD.Role_Instructor)]
        [HttpPost]
        public async Task<IActionResult> Create(Course course)
        {
            _context.Course.Add(course);
            await _context.SaveChangesAsync();
            return Redirect("List");
        }


        public IActionResult Enroll()
        {
            return View();
        }
    }
}
