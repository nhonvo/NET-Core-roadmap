using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.API.AppResult;
using StudentManagement.API.Repository.IRepository;
using StudentManagement.Core.Models.CourseViewModel;
using StudentManagement.Core.Models.GradeViewModel;

namespace StudentManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GradeController : ControllerBase
    {
        private readonly IGradeRepository _gradeRep;
        private readonly IMapper _mapper;

        public GradeController(IGradeRepository gradeRep, IMapper mapper)
        {
            _gradeRep = gradeRep;
            _mapper = mapper;
        }

        [HttpGet("Get")]
        public async Task<ApiResult<IEnumerable<GradeDTO>>> GetAllAsync()
        {
            try
            {
                var grades = await _gradeRep.GetListAsync();
                var gradeDTOs = _mapper.Map<IEnumerable<GradeDTO>>(grades);
                return new ApiSuccessResult<IEnumerable<GradeDTO>>(gradeDTOs);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<IEnumerable<GradeDTO>>(message: "Error getting grades: " + ex.Message);
            }
        }

        [HttpGet("Get{id}")]
        public async Task<ApiResult<GradeDTO>> GetByIdAsync(int id)
        {
            try
            {
                var grade = await _gradeRep.GetByIdAsync(id);
                if (grade == null)
                {
                    return new ApiErrorResult<GradeDTO>(message: "Grade not found");
                }

                var gradeDTO = _mapper.Map<GradeDTO>(grade);
                return new ApiSuccessResult<GradeDTO>(gradeDTO);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<GradeDTO>(message: "Error getting grade: " + ex.Message);
            }
        }

        [HttpPost("Create")]
        public async Task<ApiResult<GradeDTO>> CreateAsync([FromBody] GradeDTO gradeDTO)
        {
            if (gradeDTO == null)
            {
                return new ApiErrorResult<GradeDTO>(message: "Invalid grade data");
            }

            try
            {
                var grade = _mapper.Map<Grade>(gradeDTO);
                await _gradeRep.AddAsync(grade);
                await _gradeRep.CommitAsync();
                var createdGradeDTO = _mapper.Map<GradeDTO>(grade);
                return new ApiSuccessResult<GradeDTO>(createdGradeDTO);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<GradeDTO>(message: "Error creating grade: " + ex.Message);
            }
        }

        [HttpPut("Update/{id}")]
        public async Task<ApiResult<GradeDTO>> UpdateAsync(int id, [FromBody] GradeDTO gradeDTO)
        {
            if (gradeDTO == null)
            {
                return new ApiErrorResult<GradeDTO>(message: "Invalid grade data");
            }

            try
            {
                var currentGrade = await _gradeRep.GetByIdAsync(id);
                if (currentGrade == null)
                {
                    return new ApiErrorResult<GradeDTO>(message: "Grade not found");
                }

                _mapper.Map(gradeDTO, currentGrade);
                _gradeRep.Update(currentGrade);
                await _gradeRep.CommitAsync();

                return new ApiSuccessResult<GradeDTO>(_mapper.Map<GradeDTO>(currentGrade));
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<GradeDTO>(message: "Error updating grade: " + ex.Message);
            }
        }

        [HttpPatch("UpdatePart/{id}")]
        public async Task<ApiResult<GradeDTO>> PatchAsync(int id, [FromBody] JsonPatchDocument<GradeDTO> patchDocument)
        {
            if (patchDocument == null)
            {
                return new ApiErrorResult<GradeDTO>(message: "Invalid patch document");
            }

            try
            {
                var currentGrade = await _gradeRep.GetByIdAsync(id);
                if (currentGrade == null)
                {
                    return new ApiErrorResult<GradeDTO>(message: "Grade not found");
                }

                var gradeDTO = _mapper.Map<GradeDTO>(currentGrade);
                patchDocument.ApplyTo(gradeDTO);
                _mapper.Map(gradeDTO, currentGrade);

                await _gradeRep.CommitAsync();

                return new ApiSuccessResult<GradeDTO>(_mapper.Map<GradeDTO>(currentGrade));
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<GradeDTO>(message: "Error updating grade: " + ex.Message);
            }
        }

        [HttpDelete("Delete{id}")]
        public async Task<ApiResult<bool>> DeleteAsync(int id)
        {
            try
            {
                var grade = await _gradeRep.GetByIdAsync(id);
                if (grade == null)
                {
                    return new ApiErrorResult<bool>(message: "Grade not found");
                }

                _gradeRep.Delete(grade);
                await _gradeRep.CommitAsync();
                return new ApiSuccessResult<bool>(true);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<bool>(message: "Error deleting grade: " + ex.Message);
            }
        }
    }
}