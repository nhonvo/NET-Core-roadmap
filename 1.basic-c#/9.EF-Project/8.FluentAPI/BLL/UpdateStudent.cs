using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8.FluentAPI.BLL
{
    public class UpdateStudent
    {
        private readonly SchoolContext _db;

        public UpdateStudent()
        {
            _db = new SchoolContext();
        }
        public void Update(Student stud)
        {
            // Disconnected Student entity

            stud.Name = "Steve";

            _db.Update<Student>(stud);

            // or the followings are also valid
            // _db.Students.Update(stud);
            // _db.Attach<Student>(stud).State = EntityState.Modified;
            // _db.Entry<Student>(stud).State = EntityState.Modified; 

            _db.SaveChanges();
        }
        public void UpdateMultiped(IList<Student> modifiedStudents)
        {

            _db.UpdateRange(modifiedStudents);

            // or the followings are also valid
            //_db.UpdateRange(modifiedStudent1, modifiedStudent2, modifiedStudent3);
            //_db.Students.UpdateRange(modifiedStudents);
            //_db.Students.UpdateRange(modifiedStudent1, modifiedStudent2, modifiedStudent3);

            _db.SaveChanges();
        }

    }
}