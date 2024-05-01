using L107Classes._2QuanLySinhVien;
using System.ComponentModel;
class Program
{

    public static void Main(string[] args)
    {
        ListStudent list = new ListStudent();
        Console.WriteLine("Add 5 student");
        list.Add(new Student(1, "Truong", "Nhon"));
        list.Add(new Student(2, "John", "Don"));
        list.Add(new Student(3, "Hoang", "Hiep"));
        list.Add(new Student(4, "Trinh", "Tam"));
        list.Add(new Student(5, "Ho", "Duy"));
        list.Print();
        Console.WriteLine("Update 5 student");
        Student student1 = new Student(1, "Vo", "Nhon");
        Student student2 = new Student(2, "Vo", "Nhon");
        Student student3 = new Student(3, "Vo", "Nhon");
        Student student4 = new Student(4, "Vo", "Nhon");
        Student student5 = new Student(5, "Vo", "Nhon");
        list.Update(student1);
        list.Update(student2);
        list.Update(student3);
        list.Update(student4);
        list.Update(student5);
        list.Print();
        Console.WriteLine("Remove 5 Student");
        list.Remove(1);
        list.Remove(2);
        list.Remove(3);
        list.Remove(4);
        list.Remove(5);
        list.Print();
    }
}