using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatformGroup5.Data;
using OnlineLearningPlatformGroup5.Models;

namespace OnlineLearningPlatformGroup5.Controllers
{
    public class EnrollmentController : Controller
    {
        //Reach out the database to take data
        private readonly DatabaseContext _context;
        public EnrollmentController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //Include
            List<Enrollment> enrollments = _context.Enrollment.ToList();
            return View(enrollments);
        }

        public IActionResult Enroll(int id)
        {
            Course course = _context.Course.FirstOrDefault(x => x.Id == id);
            ViewBag.Course = course;
            return View();
          
        }

        [HttpPost]
        public IActionResult Enroll(Enrollment enrollment)
        {
            _context.Enrollment.Add(enrollment);
            _context.SaveChanges();
            return Redirect("Index");
        }

    }
}
