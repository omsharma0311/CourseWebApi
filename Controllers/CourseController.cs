using CourseWebApi.Models;
using CourseWebApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AutoMapper;
using CourseWebApi.DTO;

namespace CourseWebApi.Controllers
{
    [ApiController]
    [Route("api/courses")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        private readonly IMapper _mapper;
        public CourseController(ICourseService courseservice, IMapper mapper)
        {
            _courseService = courseservice;
            _mapper = mapper;
        }

        [HttpGet("GetAll")]
        public ActionResult <IEnumerable<CourseModel>> GetAllCourse()
        {
            //return Ok(_courseService.GetAllCourses());
            var CoursesList = _courseService.GetAllCourses();
            return Ok(CoursesList);
        }

        [HttpGet("{id}")]
        public ActionResult GetSingleCourse(int id)
        {
            //return Ok(_courseService.GetCourseById(id));
            var courseItem = _courseService.GetCourseById(id);
            if (courseItem != null)
            {
                return Ok(courseItem);
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult <CourseCreateUpdateDto> AddCourse(CourseCreateUpdateDto courseCreateUpdateDto)
        {
            //return Ok(_courseService.AddCourse(newCourse));
            var newCourse = _mapper.Map<CourseModel>(courseCreateUpdateDto);
            _courseService.AddCourse(newCourse);
            _courseService.SaveChanges();
            return Ok(newCourse);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateBooks(int id, CourseCreateUpdateDto courseCreateUpdateDto)
        {
            //return Ok(_courseService.UpdateCourse(id));
            var courseDetails = _courseService.GetCourseById(id);
            if (courseDetails == null)
            {
                return NotFound();
            }
            _mapper.Map(courseCreateUpdateDto, courseDetails);
            _courseService.UpdateCourse(courseDetails);
            _courseService.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCourses(int id)
        {
            //return Ok(_courseService.DeleteCourse(id));
            var courseDetails = _courseService.GetCourseById(id);
            if (courseDetails == null)
            {
                return NotFound();
            }
            _courseService.DeleteCourse(courseDetails);
            _courseService.SaveChanges();
            return NoContent();
        }

    }
}
