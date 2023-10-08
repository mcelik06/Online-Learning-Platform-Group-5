using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        [Authorize(Roles = SD.Role_Admin + ","+ SD.Role_Instructor)]
        public IActionResult Create(int id)
        {
<<<<<<< HEAD
            ViewBag.Id = id;    
            //Course course = _contextAssignment.Course.FirstOrDefault(x => x.Id == id);
            //ViewBag.Course = course;
=======
            
            Course course = _contextAssignment.Course.FirstOrDefault(x => x.Id == id);
            ViewBag.Course = course;
>>>>>>> 69396fe60a98ac123aff8c08447747050af3017f
            return View();
        }

        [Authorize(Roles = SD.Role_Admin + ","+ SD.Role_Instructor)]
        [HttpPost]
        public IActionResult Create([Bind(include:"Id,CourseId,Title,Description,DueDate")] Assignment assignment)
        {
<<<<<<< HEAD
            //_contextAssignment.Database.ExecuteSqlRaw
            using (var transaction = _contextAssignment.Database.BeginTransaction())
            {
                
                _contextAssignment.Assignment.Add(assignment);
                _contextAssignment.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Assignment ON");
                _contextAssignment.SaveChanges();
                _contextAssignment.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Assignment OFF");
                transaction.Commit();
            }
            //_contextAssignment.Assignment.Add(assignment);
            //_contextAssignment.SaveChanges();
            return RedirectToAction("ListCourses");
=======

            _contextAssignment.Assignment.Add(assignment);
            _contextAssignment.SaveChanges();

            return Redirect("ListCourses");
>>>>>>> 69396fe60a98ac123aff8c08447747050af3017f
        }

    }
}
