using ElevateProjectFinal.DataAccess.Repository;
using ElevateProjectFinal.DataAccess.Repository.Irepository;
using ElevateProjectFinal.Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElevateProjectFinal.Areas.Student

{
    [Area("Student")]
    public class StudentController : Controller
    {

        private readonly ILogger<StudentController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public StudentController(ILogger<StudentController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
        public IActionResult BrowseCourses()
        {
            IEnumerable<Course> courseList = _unitOfWork.Course.GetAll(includeProperties: "Course");
            return View(courseList);
            
        }

        // Action for accessing course content
        public IActionResult CourseContent(int courseId)
        {
            Course course = _unitOfWork.Course.Get(u => u.CourseId == courseId);
            return View();
        }

        // Action for viewing assignments and submitting work
        public IActionResult ViewAssignments(int courseId)
        {
            IEnumerable<Assignment> assignmentList = _unitOfWork.Assignment.GetSpecificAll(u=> u.CourseId == courseId);
            return View(assignmentList);
        }

        // Action for tracking progress and viewing grades
        public IActionResult TrackProgress()
        {
            
            return View();
        }
    }
}
