using AutoMapper;
using CourseWebApi.Models;

namespace CourseWebApi.DTO
{
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            //Source -> Target
            CreateMap<CourseCreateUpdateDto, CourseModel>();
            CreateMap<CourseModel, CourseCreateUpdateDto>();
        }
    }
}
