using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.API.AppResult;
using StudentManagement.API.Repository.IRepository;
using StudentManagement.Core.Models.CourseViewModel;
using StudentManagement.Core.Models.StudentAddressViewModel;

namespace StudentManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentAddressController : ControllerBase
    {
        private readonly IStudentAddressRepository _studentAddressRep;
        private readonly IMapper _mapper;

        public StudentAddressController(IStudentAddressRepository studentAddressRep, IMapper mapper)
        {
            _studentAddressRep = studentAddressRep;
            _mapper = mapper;
        }

        [HttpGet("Get")]
        public async Task<ApiResult<IEnumerable<StudentAddressDTO>>> GetAllAsync()
        {
            try
            {
                var studentAddresses = await _studentAddressRep.GetListAsync();
                var studentAddressDTOs = _mapper.Map<IEnumerable<StudentAddressDTO>>(studentAddresses);
                return new ApiSuccessResult<IEnumerable<StudentAddressDTO>>(studentAddressDTOs);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<IEnumerable<StudentAddressDTO>>(message: "Error getting student addresses: " + ex.Message);
            }
        }

        [HttpGet("Get/{id}")]
        public async Task<ApiResult<StudentAddressDTO>> GetByIdAsync(int id)
        {
            try
            {
                var studentAddress = await _studentAddressRep.GetByIdAsync(id);
                if (studentAddress == null)
                {
                    return new ApiErrorResult<StudentAddressDTO>(message: "Student address not found");
                }

                var studentAddressDTO = _mapper.Map<StudentAddressDTO>(studentAddress);
                return new ApiSuccessResult<StudentAddressDTO>(studentAddressDTO);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<StudentAddressDTO>(message: "Error getting student address: " + ex.Message);
            }
        }

        [HttpPost("Create")]
        public async Task<ApiResult<StudentAddressDTO>> CreateAsync([FromBody] StudentAddressDTO studentAddressDTO)
        {
            if (studentAddressDTO == null)
            {
                return new ApiErrorResult<StudentAddressDTO>(message: "Invalid student address data");
            }

            try
            {
                var studentAddress = _mapper.Map<StudentAddress>(studentAddressDTO);
                await _studentAddressRep.AddAsync(studentAddress);
                await _studentAddressRep.CommitAsync();
                var createdStudentAddressDTO = _mapper.Map<StudentAddressDTO>(studentAddress);
                return new ApiSuccessResult<StudentAddressDTO>(createdStudentAddressDTO);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<StudentAddressDTO>(message: "Error creating student address: " + ex.Message);
            }
        }

        [HttpPut("Update/{id}")]
        public async Task<ApiResult<StudentAddressDTO>> UpdateAsync(int id, [FromBody] StudentAddressDTO studentAddressDTO)
        {
            if (studentAddressDTO == null)
            {
                return new ApiErrorResult<StudentAddressDTO>(message: "Invalid student address data");
            }

            try
            {
                var currentStudentAddress = await _studentAddressRep.GetByIdAsync(id);
                if (currentStudentAddress == null)
                {
                    return new ApiErrorResult<StudentAddressDTO>(message: "Student address not found");
                }

                _mapper.Map(studentAddressDTO, currentStudentAddress);
                _studentAddressRep.Update(currentStudentAddress);
                await _studentAddressRep.CommitAsync();

                return new ApiSuccessResult<StudentAddressDTO>(_mapper.Map<StudentAddressDTO>(currentStudentAddress));
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<StudentAddressDTO>(message: "Error updating student address: " + ex.Message);
            }
        }

        [HttpPatch("UpdatePart/{id}")]
        public async Task<ApiResult<StudentAddressDTO>> PatchAsync(int id, [FromBody] JsonPatchDocument<StudentAddressDTO> patchDocument)
        {
            if (patchDocument == null)
            {
                return new ApiErrorResult<StudentAddressDTO>(message: "Invalid patch document");
            }

            try
            {
                var currentStudentAddress = await _studentAddressRep.GetByIdAsync(id);
                if (currentStudentAddress == null)
                {
                    return new ApiErrorResult<StudentAddressDTO>(message: "Student address not found");
                }

                var studentAddressDTO = _mapper.Map<StudentAddressDTO>(currentStudentAddress);
                patchDocument.ApplyTo(studentAddressDTO);
                _mapper.Map(studentAddressDTO, currentStudentAddress);

                await _studentAddressRep.CommitAsync();

                return new ApiSuccessResult<StudentAddressDTO>(_mapper.Map<StudentAddressDTO>(currentStudentAddress));
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<StudentAddressDTO>(message: "Error patching student address: " + ex.Message);
            }
        }
        [HttpDelete("Delete{id}")]
        public async Task<ApiResult<bool>> Delete(int id)
        {
            try
            {
                var studentAddress = await _studentAddressRep.GetByIdAsync(id);
                if (studentAddress == null)
                {
                    return new ApiErrorResult<bool>(message: "Student address not found");
                }

                _studentAddressRep.Delete(studentAddress);
                await _studentAddressRep.CommitAsync();

                return new ApiSuccessResult<bool>(true);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<bool>(message: "Error deleting student address: " + ex.Message);
            }
        }
    }
}