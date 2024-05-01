using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.API.AppResult;
using StudentManagement.API.Repository.IRepository;
using StudentManagement.Core.Models.StudentCourseViewModel;

namespace StudentManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentCourseController : ControllerBase
    {
        private readonly IStudentCourseRepository _studentCourseRep;
        private readonly IMapper _mapper;

        public StudentCourseController(IStudentCourseRepository studentCourseRep, IMapper mapper)
        {
            _studentCourseRep = studentCourseRep;
            _mapper = mapper;
        }

        [HttpGet("Get")]
        public async Task<ApiResult<IEnumerable<StudentCourseDTO>>> GetAllAsync()
        {
            try
            {
                var studentCourses = await _studentCourseRep.GetListAsync();
                var studentCourseDTOs = _mapper.Map<IEnumerable<StudentCourseDTO>>(studentCourses);
                return new ApiSuccessResult<IEnumerable<StudentCourseDTO>>(studentCourseDTOs);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<IEnumerable<StudentCourseDTO>>(message: "Error getting student courses: " + ex.Message);
            }
        }

        [HttpGet("Get/{id}")]
        public async Task<ApiResult<StudentCourseDTO>> GetByIdAsync(int id)
        {
            try
            {
                var studentCourse = await _studentCourseRep.GetByIdAsync(id);
                if (studentCourse == null)
                {
                    return new ApiErrorResult<StudentCourseDTO>(message: "Student course not found");
                }

                var studentCourseDTO = _mapper.Map<StudentCourseDTO>(studentCourse);
                return new ApiSuccessResult<StudentCourseDTO>(studentCourseDTO);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<StudentCourseDTO>(message: "Error getting student course: " + ex.Message);
            }
        }

        [HttpPost("Create")]
        public async Task<ApiResult<StudentCourseDTO>> CreateAsync([FromBody] StudentCourseDTO studentCourseDTO)
        {
            if (studentCourseDTO == null)
            {
                return new ApiErrorResult<StudentCourseDTO>(message: "Invalid student course data");
            }

            try
            {
                var studentCourse = _mapper.Map<StudentCourse>(studentCourseDTO);
                await _studentCourseRep.AddAsync(studentCourse);
                await _studentCourseRep.CommitAsync();
                var createdStudentCourseDTO = _mapper.Map<StudentCourseDTO>(studentCourse);
                return new ApiSuccessResult<StudentCourseDTO>(createdStudentCourseDTO);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<StudentCourseDTO>(message: "Error creating student course: " + ex.Message);
            }
        }

        [HttpPut("Update/{id}")]
        public async Task<ApiResult<StudentCourseDTO>> UpdateAsync(int id, [FromBody] StudentCourseDTO studentCourseDTO)
        {
            if (studentCourseDTO == null)
            {
                return new ApiErrorResult<StudentCourseDTO>(message: "Invalid student course data");
            }

            try
            {
                var existingStudentCourse = await _studentCourseRep.GetByIdAsync(id);
                if (existingStudentCourse == null)
                {
                    return new ApiErrorResult<StudentCourseDTO>(message: "Student course not found");
                }

                var updatedStudentCourse = _mapper.Map(studentCourseDTO, existingStudentCourse);
                await _studentCourseRep.CommitAsync();
                var updatedStudentCourseDTO = _mapper.Map<StudentCourseDTO>(updatedStudentCourse);
                return new ApiSuccessResult<StudentCourseDTO>(updatedStudentCourseDTO);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<StudentCourseDTO>(message: "Error updating student course: " + ex.Message);
            }
        }

        [HttpDelete("Delete{id}")]
        public async Task<ApiResult<bool>> Delete(int id)
        {
            try
            {
                var studentCourse = await _studentCourseRep.GetByIdAsync(id);
                if (studentCourse == null)
                {
                    return new ApiErrorResult<bool>(message: "Student course not found");
                }

                _studentCourseRep.Delete(studentCourse);
                await _studentCourseRep.CommitAsync();

                return new ApiSuccessResult<bool>(true);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<bool>(message: "Error deleting student course: " + ex.Message);
            }
        }
    }
}