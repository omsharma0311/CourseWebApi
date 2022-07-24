using CourseWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebApi.Services
{
    public interface ICourseService
    {
            bool SaveChanges();
            IEnumerable<CourseModel> GetAllCourses();
            CourseModel GetCourseById(int id);
            void AddCourse(CourseModel newCourse);
            void UpdateCourse(CourseModel newCourse);
            void DeleteCourse(CourseModel newCourse);

    }
}
