using System.ComponentModel.DataAnnotations;

namespace CourseWebApi.DTO
{
    public class CourseCreateUpdateDto
    {
        [Required]
        public string CourseName { get; set; }

        [Required]
        public string CourseCode { get; set; }

        [Required]
        public double CourseRating { get; set; }
    }
}
