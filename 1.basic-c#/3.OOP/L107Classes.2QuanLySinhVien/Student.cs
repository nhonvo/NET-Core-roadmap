using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L107Classes._2QuanLySinhVien
{
    public class Student
    {
        public Student()
        {

        }
        public Student(int Id, string firstName, string lastName)
        {
            this.Id = Id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void Input(Student student)
        {
            Console.WriteLine("Enter id: ");
            student.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Firstname: ");
            student.FirstName = Console.ReadLine()!;
            Console.WriteLine("Enter Lastname: ");
            student.LastName = Console.ReadLine()!;
        }
        internal void Output(Student student)
        {
            Console.WriteLine($"{student.Id} {student.FirstName} {student.LastName}");
        } 
    }
}
