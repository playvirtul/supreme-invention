using MentorPlatform.API.DTO;
using Microsoft.AspNetCore.Mvc;

namespace MentorPlatform.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CourseController : ControllerBase
    {
        public static CourseResponse[] Courses = new[]
        {
            new CourseResponse
            {
                Name = "Python Developer"
            },
            new CourseResponse
            {
                Name = "ML Engineer"
            },
            new CourseResponse
            {
                Name = "DevOPS"
            }
        };

        [HttpGet(Name = "GetCourses")]
        public ActionResult<CourseResponse[]> GetCourses()
        {
            return Ok(Courses);
        }
    }
}
