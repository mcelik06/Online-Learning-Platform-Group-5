using ElevateProjectFinal.DataAccess.Data;
using ElevateProjectFinal.DataAccess.Repository.Irepository;
using ElevateProjectFinal.Models.Models;
using ElevateProjectFinal.Models.ViewModels;
using ElevateProjectFinal.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ElevateProjectFinal.Areas.Instructor
{
    [Area("Instructor")]
    [Authorize(Roles = SD.Role_Instructor)]
    public class InstructorController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        public InstructorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // Action for creating and managing courses
        public IActionResult CreateCourse()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Course obj)
        {

            if (ModelState.IsValid)
            {
                _unitOfWork.Course.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Course created successfully";
                return RedirectToAction("Index");
            }
            return View();

        }

        // Action for adding assignments to a course
        public IActionResult AddAssignment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAssignment(int courseId)
        {
            Course course = _unitOfWork.Course.Get(u => u.CourseId == courseId);
            if (course == null)
            {
                return NotFound();
            }

            return View(new Assignment { CourseId = courseId });
        }

        // Action for modifying course content
        public IActionResult EditCourseContent(int courseId)
        {
            if (courseId == null || courseId == 0)
            {
                return NotFound();
            }
            Course CourseFromDb = _unitOfWork.Course.Get(u => u.CourseId == courseId);
            if (CourseFromDb == null)
            {
                return NotFound();
            }
            return View(CourseFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Course obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Course.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Course updated successfully";
                return RedirectToAction("Index");
            }
            return View();

        }

        // Action for tracking student progress and viewing analytics
        public IActionResult TrackStudentProgress(int courseId)
        {
            
            return View();
        }

        // Action for viewing student enrollment in a course
        public IActionResult ViewStudentEnrollment(int courseId)
        {

            IEnumerable<Enrollment> enrollmentList = _unitOfWork.Enrollment.GetSpecificAll(u => u.CourseId == courseId);
            return View(enrollmentList);
        }
    }

}
