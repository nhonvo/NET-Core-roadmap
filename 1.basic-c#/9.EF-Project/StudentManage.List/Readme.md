# The restful api for Student management applications

## Entity: Student, Course, Grade, StudentCourse, StudentAddress

- Course(Id, Name, Description)
- Grade(Id, Name, Section)
- Student(Id, Name, _GradeId_)
- StudentAddress(Id, Address, City, State, Country, _AddressOfStudentId_)
- StudentCourse(_StudentId_, _CourseId_)

## Project Details: has two part StudentManageList.Core and StudentManageList.API

    - StudentManageList.Core: Model, db, migration, repository.
    - StudentManageList.API: Controller, Program. 

## Contributors

    - Truong Nhon
