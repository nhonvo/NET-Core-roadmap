using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8.FluentAPI.BLL
{
    public class InsertStudent
    {
        private readonly SchoolContext _db;
        public InsertStudent()
        {
            _db = new SchoolContext();
        }
        public void ViewAll()
        {
            var db = new SchoolContext();
            var list = db.Students;
            foreach (var item in list)
            {
                System.Console.WriteLine(item.Name);
            }
        }
        public void Insert(Student std)
        {
            try
            {
                using (var context = new SchoolContext())
                {
                    //1. Attach an entity to context with Added EntityState
                    // context.Add<Student>(std);

                    //or the followings are also valid
                    context.Students.Add(std);
                    // context.Entry<Student>(std).State = EntityState.Added;
                    // context.Attach<Student>(std);

                    //2. Calling SaveChanges to insert a new record into Students table
                    context.SaveChanges();
                }
            }
            catch (System.Exception)
            {

                throw new Exception("Can't add student");
            }
        }
        public void InsertMultiped(List<Object> obj)
        {
            using (var context = new SchoolContext())
            {
                context.AddRange(obj);

                // or 
                // context.AddRange(std1, std2, computer);

                context.SaveChanges();
            }
        }


    }
}