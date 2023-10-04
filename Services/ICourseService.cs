﻿using OnlineLearningPlatformGroup5.Models;

namespace OnlineLearningPlatformGroup5.Services
{
    public interface ICourseService
    {
        void Create(Course course);
        void Update(Course course);
        void Delete(int id);
        Course Read(int id);
        List<Course> ReadAll();
    }
}
