using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.API.AppResult;
using StudentManagement.API.Repository.IRepository;
using StudentManagement.Core.Models.StudentViewModel;

namespace StudentManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRep;
        private readonly IMapper _mapper;

        public StudentController(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRep = studentRepository;
            _mapper = mapper;

        }
        [HttpGet("Get/{id}")]
        public async Task<ApiResult<Student>> GetAsync(int id)
        {
            var result = await _studentRep.GetByIdAsync(id);
            if (result == null)
                return new ApiErrorResult<Student>("student not found");
            return new ApiSuccessResult<Student>(result);
        }
        [HttpGet("Get")]
        public async Task<ApiResult<IEnumerable<Student>>> GetAsync()
        {
            var result = await _studentRep.GetListAsync();
            if (result == null)
                return new ApiErrorResult<IEnumerable<Student>>(message: "student not found");
            return new ApiSuccessResult<IEnumerable<Student>>(result);
        }
        [HttpPost("Create")]
        public async Task<ApiResult<Student>> CreateAsync([FromBody] StudentDTO studentDTO)
        {
            if (studentDTO == null)
            {
                return new ApiErrorResult<Student>(message: "Invalid student data");
            }

            try
            {
                Student student = _mapper.Map<Student>(studentDTO);
                await _studentRep.AddAsync(student);
                await _studentRep.CommitAsync();
                return new ApiSuccessResult<Student>(student);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<Student>(message: "Error creating student: " + ex.Message);
            }
        }
        [HttpPut("Update/{id}")]
        public async Task<ApiResult<Student>> UpdateAsync(int id, [FromBody] StudentDTO studentDTO)
        {
            if (studentDTO == null)
            {
                return new ApiErrorResult<Student>(message: "Invalid student data");
            }

            try
            {
                Student currentStudent = await _studentRep.GetByIdAsync(id);
                if (currentStudent == null)
                {
                    return new ApiErrorResult<Student>(message: "Student not found");
                }

                _mapper.Map(studentDTO, currentStudent);
                _studentRep.Update(currentStudent);
                await _studentRep.CommitAsync();

                return new ApiSuccessResult<Student>(currentStudent);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<Student>(message: "Error updating student: " + ex.Message);
            }
        }
        [HttpPatch("UpdatePart/{id}")]
        public async Task<ApiResult<Student>> PatchAsync(int id, [FromBody] JsonPatchDocument<StudentDTO> patchDocument)
        {
            if (patchDocument == null)
            {
                return new ApiErrorResult<Student>(message: "Invalid patch document");
            }

            try
            {
                var currentStudent = await _studentRep.GetByIdAsync(id);
                if (currentStudent == null)
                {
                    return new ApiErrorResult<Student>(message: "Student not found");
                }

                var studentDTO = _mapper.Map<StudentDTO>(currentStudent);
                patchDocument.ApplyTo(studentDTO);
                _mapper.Map(studentDTO, currentStudent);

                await _studentRep.CommitAsync();

                return new ApiSuccessResult<Student>(currentStudent);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<Student>(message: "Error updating student: " + ex.Message);
            }
        }
        [HttpDelete("Delete{id}")]
        public async Task<ApiResult<bool>> DeleteAsync(int id)
        {
            try
            {
                var student = await _studentRep.GetByIdAsync(id);
                if (student == null)
                {
                    return new ApiErrorResult<bool>(message: "Student not found");
                }

                _studentRep.Delete(student);
                await _studentRep.CommitAsync();

                return new ApiSuccessResult<bool>(true);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<bool>(message: "Error deleting student: " + ex.Message);
            }
        }
    }
}