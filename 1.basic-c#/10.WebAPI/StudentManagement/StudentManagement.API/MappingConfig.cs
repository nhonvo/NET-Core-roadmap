using AutoMapper;
using StudentManagement.Core.Models.CourseViewModel;
using StudentManagement.Core.Models.GradeViewModel;
using StudentManagement.Core.Models.StudentAddressViewModel;
using StudentManagement.Core.Models.StudentCourseViewModel;
using StudentManagement.Core.Models.StudentViewModel;

namespace StudentManagement.API
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {

            CreateMap<Student, StudentDTO>();
            CreateMap<Student, StudentDTO>().ReverseMap();
            CreateMap<Course, CourseDTO>();
            CreateMap<Course, CourseDTO>().ReverseMap();
            CreateMap<Grade, GradeDTO>();
            CreateMap<Grade, GradeDTO>().ReverseMap();
            CreateMap<StudentAddress, StudentAddressDTO>();
            CreateMap<StudentAddress, StudentAddressDTO>().ReverseMap();
            CreateMap<StudentCourse, StudentCourseDTO>();
            CreateMap<StudentCourse, StudentCourseDTO>().ReverseMap();

        }
    }
}