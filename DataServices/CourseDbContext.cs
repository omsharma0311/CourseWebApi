using CourseWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseWebApi.DataServices
{
    public class CourseDbContext :  DbContext
    {
        public CourseDbContext(DbContextOptions<CourseDbContext> opt) : base(opt)
        { 

        }
        public DbSet<CourseModel> Courses { get; set; }
    }
}
