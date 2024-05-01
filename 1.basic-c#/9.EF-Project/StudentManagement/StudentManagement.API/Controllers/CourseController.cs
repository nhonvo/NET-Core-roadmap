using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.API.AppResult;
using StudentManagement.API.Repository.IRepository;
using StudentManagement.Core.Models.CourseViewModel;

namespace StudentManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepository _courseRep;
        private readonly IMapper _mapper;
        public CourseController(ICourseRepository courseRep, IMapper mapper)
        {
            _courseRep = courseRep;
            _mapper = mapper;
        }

        [HttpGet("Get")]
        public async Task<ApiResult<IEnumerable<Course>>> GetAsync()
        {
            try
            {
                var courses = await _courseRep.GetListAsync();
                return new ApiSuccessResult<IEnumerable<Course>>(courses);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<IEnumerable<Course>>(message: "Error getting courses: " + ex.Message);
            }
        }

        [HttpGet("Get{id}")]
        public async Task<ApiResult<Course>> GetByIdAsync(int id)
        {
            try
            {
                var course = await _courseRep.GetByIdAsync(id);
                if (course == null)
                {
                    return new ApiErrorResult<Course>(message: "Course not found");
                }

                return new ApiSuccessResult<Course>(course);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<Course>(message: "Error getting course: " + ex.Message);
            }
        }

        [HttpPost("Create")]
        public async Task<ApiResult<Course>> CreateAsync([FromBody] CourseDTO courseDTO)
        {
            if (courseDTO == null)
            {
                return new ApiErrorResult<Course>(message: "Invalid course data");
            }

            try
            {
                var course = _mapper.Map<Course>(courseDTO);
                await _courseRep.AddAsync(course);
                await _courseRep.CommitAsync();
                return new ApiSuccessResult<Course>(course);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<Course>(message: "Error creating course: " + ex.Message);
            }
        }

        [HttpPut("Update/{id}")]
        public async Task<ApiResult<Course>> UpdateAsync(int id, [FromBody] CourseDTO courseDTO)
        {
            if (courseDTO == null)
            {
                return new ApiErrorResult<Course>(message: "Invalid course data");
            }

            try
            {
                var currentCourse = await _courseRep.GetByIdAsync(id);
                if (currentCourse == null)
                {
                    return new ApiErrorResult<Course>(message: "Course not found");
                }

                _mapper.Map(courseDTO, currentCourse);
                _courseRep.Update(currentCourse);
                await _courseRep.CommitAsync();

                return new ApiSuccessResult<Course>(currentCourse);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<Course>(message: "Error updating course: " + ex.Message);
            }
        }

        [HttpPatch("UpdatePart/{id}")]
        public async Task<ApiResult<Course>> PatchAsync(int id, [FromBody] JsonPatchDocument<CourseDTO> patchDocument)
        {
            if (patchDocument == null)
            {
                return new ApiErrorResult<Course>(message: "Invalid patch document");
            }

            try
            {
                var currentCourse = await _courseRep.GetByIdAsync(id);
                if (currentCourse == null)
                {
                    return new ApiErrorResult<Course>(message: "Course not found");
                }

                var courseDTO = _mapper.Map<CourseDTO>(currentCourse);
                patchDocument.ApplyTo(courseDTO);
                _mapper.Map(courseDTO, currentCourse);

                await _courseRep.CommitAsync();

                return new ApiSuccessResult<Course>(currentCourse);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<Course>(message: "Error updating course: " + ex.Message);
            }
        }

        [HttpDelete("Delete{id}")]
        public async Task<ApiResult<bool>> Delete(int id)
        {
            try
            {
                var course = await _courseRep.GetByIdAsync(id);
                if (course == null)
                {
                    return new ApiErrorResult<bool>(message: "Course not found");
                }

                _courseRep.Delete(course);
                await _courseRep.CommitAsync();

                return new ApiSuccessResult<bool>(true);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<bool>(message: "Error deleting course: " + ex.Message);
            }
        }
    }
}