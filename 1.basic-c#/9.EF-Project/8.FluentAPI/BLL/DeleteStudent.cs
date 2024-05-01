using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8.FluentAPI.BLL
{

    public class DeleteStudent
    {
        private readonly SchoolContext _db;
        public DeleteStudent()
        {

            _db = new SchoolContext();
        }

        public void Remove(Student student)
        {
            _db.Remove<Student>(student);

            // or the followings are also valid
            // _db.RemoveRange(student);
            //_db.Students.Remove(student);
            //_db.Students.RemoveRange(student);
            //_db.Attach<Student>(student).State = EntityState.Deleted;
            //_db.Entry<Student>(student).State = EntityState.Deleted;

            _db.SaveChanges();
        }
        public void RemoveWithException(Student student)
        {
            try
            {
                _db.Remove<Student>(student);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Record does not exist in the database");
            }
           
        }
        public void RemoveMultiple(IList<Student> students)
        {
            _db.RemoveRange(students);

            // or
            // _db.Students.RemoveRange(students);

            _db.SaveChanges();
        }

    }
}