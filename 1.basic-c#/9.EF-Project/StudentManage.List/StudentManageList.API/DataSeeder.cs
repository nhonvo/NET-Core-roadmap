using Microsoft.EntityFrameworkCore;
using StudentManageList.Core.Models.CourseViewModel;
using StudentManageList.Core.Models.GradeViewModel;
using StudentManageList.Core.Models.StudentViewModel;
using StudentManageList.Core.Models.StudentAddressViewModel;
using StudentManageList.Core.Models.StudentCourseViewModel;

namespace StudentManageList.API
{

    public static class DataSeeder
    {
        public static List<Grade> Grades = new List<Grade>
            {
                new Grade { Id = 1, Name = "University", Section = "A", Students = new List<Student>() },
                new Grade { Id = 2, Name = "High school", Section = "B", Students = new List<Student>() },
                new Grade { Id = 3, Name = "Low school", Section = "C", Students = new List<Student>() }
            };

        public static List<Student> _students = new List<Student>
            {
                new Student { Id = 1, Name = "John", GradeId = 1, Grade = Grades[0], Address = null, StudentCourses = new List<StudentCourse>() },
                new Student { Id = 2, Name = "Jane", GradeId = 2, Grade = Grades[1], Address = null, StudentCourses = new List<StudentCourse>() },
                new Student { Id = 3, Name = "Jim", GradeId = 3, Grade = Grades[2], Address = null, StudentCourses = new List<StudentCourse>() }
            };

        public static List<StudentAddress> StudentAddresses = new List<StudentAddress>
            {
                new StudentAddress { Id = 1, Address = "123 Main St", City = "New York", State = "NY", Country = "USA", AddressOfStudentId = 1, Student = _students[0] },
                new StudentAddress { Id = 2, Address = "456 Elm St", City = "Los Angeles", State = "CA", Country = "USA", AddressOfStudentId = 2, Student = _students[1] },
                new StudentAddress { Id = 3, Address = "789 Oak St", City = "Chicago", State = "IL", Country = "USA", AddressOfStudentId = 3, Student = _students[2] }
            };
        public static List<Course> Courses = new List<Course>{

                new Course { Id = 1, Name = "Mathematics", Description = "This is a Mathematics course" },
                new Course { Id = 2, Name = "Science", Description = "This is a Science course" },
                new Course { Id = 3, Name = "History", Description = "This is a History course" }
            };
        public static List<StudentCourse> StudentCourses = new List<StudentCourse> {
                new StudentCourse { StudentId = 1, CourseId = 1 },
                new StudentCourse { StudentId = 1, CourseId = 2 },
                new StudentCourse { StudentId = 2, CourseId = 2 },
                new StudentCourse { StudentId = 2, CourseId = 3 },
                new StudentCourse { StudentId = 3, CourseId = 1 }
            };
        public static async Task AddAsync(Student student)
        {
            student.Id = _students.Max(s => s.Id) + 1; // generate new Id
            _students.Add(student);
        }

        public static void  Delete(int id)
        {
            var student = GetById(id);
            if (student != null)
            {
                _students.Remove(student);
            }
        }

        public static async Task<IEnumerable<Student>> GetAllAsync()
        {
            return _students;
        }

        public static async Task<Student> GetByIdAsync(int id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }

        public static void Update(Student student)
        {
            var existingStudent = GetById(student.Id);
            if (existingStudent != null)
            {
                existingStudent.Name = student.Name;
                existingStudent.GradeId = student.GradeId;
                existingStudent.Grade = student.Grade;
                existingStudent.Address = student.Address;
                existingStudent.StudentCourses = student.StudentCourses;
            }
        }

        public static Student GetById(int id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }

    }
}