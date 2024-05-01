using AutoMapper;
using StudentManageList.Core.Models.CourseViewModel;
using StudentManageList.Core.Models.GradeViewModel;
using StudentManageList.Core.Models.StudentAddressViewModel;
using StudentManageList.Core.Models.StudentCourseViewModel;
using StudentManageList.Core.Models.StudentViewModel;

namespace StudentManageList.API
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