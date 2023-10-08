using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
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
            List<Enrollment> enrollments = _context.Enrollment.Include(e => e.CourseId).ToList();

            return View(enrollments);
        }

        public IActionResult Enroll(int id)
        {
            Course course = _context.Course.FirstOrDefault(x => x.Id == id);
            ViewBag.Course = course;
            DateTime now = DateTime.Now;
            ViewBag.Time = now.ToString("yyyy-MM-dd HH:mm:ss");
            return View();

        }

        [HttpPost]
        public IActionResult Enroll( Enrollment enrollment)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {

                _context.Enrollment.Add(enrollment);
                _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Enrollment ON");
                _context.SaveChanges();
                _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Enrollment OFF");
                transaction.Commit();
            }

            //_context.Enrollment.Add(enrollment);
            //_context.SaveChanges();
            return Redirect("Index");
        }
        //[Bind("UserId,CourseId,EnrollmentDate")]
    }
}
