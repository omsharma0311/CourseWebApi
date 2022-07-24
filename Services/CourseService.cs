using CourseWebApi.DataServices;
using CourseWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebApi.Services
{
    public class CourseService : ICourseService
    {
        private readonly CourseDbContext _courseContext;
        public CourseService(CourseDbContext courseContext)
        {
            _courseContext = courseContext;
        }
        public bool SaveChanges()
        {
            return (_courseContext.SaveChanges() >= 0);
        }

        public void AddCourse(CourseModel newCourse)
        {
            if (newCourse == null)
            {
                throw new ArgumentNullException(nameof(newCourse));
            }

            _courseContext.Courses.Add(newCourse);
        }

        public void DeleteCourse(CourseModel newCourse)
        {
            if (newCourse == null)
            {
                throw new ArgumentNullException(nameof(newCourse));
            }
            _courseContext.Courses.Remove(newCourse);
        }

        public IEnumerable<CourseModel> GetAllCourses()
        {
            return _courseContext.Courses.ToList();
        }

        public CourseModel GetCourseById(int id)
        {
            return _courseContext.Courses.FirstOrDefault(p => p.CourseId == id);
        }

        
        public void UpdateCourse(CourseModel newCourse)
        {
            //if (newCourse == null)
            //{
            //    throw new ArgumentNullException(nameof(newCourse));
            //}
            
            //CourseModel courses = _courseContext.Courses.FirstOrDefault(x => x.CourseId == newCourse.CourseId);
            //courses.CourseName = newCourse.CourseName;
            //courses.CourseCode = newCourse.CourseCode;
            //courses.CourseRating = newCourse.CourseRating;
            //_courseContext.Courses.Add(newCourse);
        }
    }
}
