using AdoSql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static p5ADONET.CRUD<T>;

namespace p5ADONET
{
    internal class genericOperator
    {
        const string _connectionString = @"Server=; Initial Catalog=p5ADONET; Integrated Security = true; MultipleActiveResultSets=true";
        static readonly CRUDOperations<Class> _classOperations = new(_connectionString, "Class");
        static readonly CRUDOperations<Student> _studentOperations = new(_connectionString, "Student");
        static readonly CRUDOperations<Subject> _subjectOperations = new(_connectionString, "Subject");
        static readonly CRUDOperations<Score> _scoreOperations = new(_connectionString, "Score");

        #region class
        public static int AddClass(Class newItem)
        {
            return _classOperations.Add(newItem);
        }

        public static List<Class> ViewClasses()
        {
            return _classOperations.GetAll();
        }

        public static int UpdateClass(int id, Class itemToUpdate)
        {
            return _classOperations.Update(id, itemToUpdate);
        }

        public static int DeleteClass(int id)
        {
            // Retrieve students
            var studentsToDelete = _studentOperations.GetAll().Where(x => x.ClassID == id);

            // Retrieve scores
            var scoresToDelete = _scoreOperations.GetAll().Where(x => studentsToDelete.Any(y => y.ID == x.StudentID));

            // Delete all associations from the database.
            _ = scoresToDelete.Select(x => _scoreOperations.Delete(x.ID));
            _ = studentsToDelete.Select(x => _studentOperations.Delete(x.ID));
            return _classOperations.Delete(id);
        }
        #endregion

        #region student
        public static int AddStudent(Student newItem)
        {
            return _studentOperations.Add(newItem);
        }

        public static List<Student> ViewStudents()
        {
            return _studentOperations.GetAll();
        }

        public static int UpdateStudent(int id, Student itemToUpdate)
        {
            return _studentOperations.Update(id, itemToUpdate);
        }

        public static int DeleteStudent(int id)
        {
            // Retrieve scores
            var scoresToDelete = _scoreOperations.GetAll().Where(x => x.StudentID == id);

            // Delete all associations from the database.
            _ = scoresToDelete.Select(x => _scoreOperations.Delete(x.ID));
            return _studentOperations.Delete(id);
        }
        #endregion

        #region subject
        public static int AddSubject(Subject newItem)
        {
            return _subjectOperations.Add(newItem);
        }

        public static List<Subject> ViewSubjects()
        {
            return _subjectOperations.GetAll();
        }

        public static int UpdateSubject(int id, Subject itemToUpdate)
        {
            return _subjectOperations.Update(id, itemToUpdate);
        }

        public static int DeleteSubject(int id)
        {
            // Retrieve scores
            var scoresToDelete = _scoreOperations.GetAll().Where(x => x.SubjectID == id);

            // Delete all associations from the database.
            _ = scoresToDelete.Select(x => _scoreOperations.Delete(x.ID));
            return _subjectOperations.Delete(id);
        }
        #endregion

        #region score
        public static int AddScore(Score newItem)
        {
            return _scoreOperations.Add(newItem);
        }

        public static List<Score> ViewScores()
        {
            return _scoreOperations.GetAll();
        }

        public static int UpdateScore(int id, Score itemToUpdate)
        {
            return _scoreOperations.Update(id, itemToUpdate);
        }

        public static int DeleteScore(int id)
        {
            return _scoreOperations.Delete(id);
        }
        #endregion

    }
}
