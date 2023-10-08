using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineLearningPlatformGroup5.Data;
using OnlineLearningPlatformGroup5.Models;
using OnlineLearningPlatformGroup5.Utility;

namespace OnlineLearningPlatformGroup5.Controllers
{
    public class AssignmentController : Controller
    {
        private readonly DatabaseContext _contextAssignment;
        public AssignmentController(DatabaseContext context)
        {
            _contextAssignment = context;
        }
        public IActionResult Index()
        {
            return View();
        }        
        
        public IActionResult ListCourses()
        {
            List<Course> courses = _contextAssignment.Course.ToList();
            return View(courses);
        }
        [Authorize(Roles = SD.Role_Instructor)]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = SD.Role_Instructor)]
        [HttpPost]
        public async Task<IActionResult> CreateAsync(Assignment assignment)
        {
            _contextAssignment.Assignment.Add(assignment);
            await _contextAssignment.SaveChangesAsync();
            return Redirect("ListCourses");
        }

    }
}
