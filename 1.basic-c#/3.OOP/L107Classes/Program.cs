using L107Classes;

List<Student> students = new List<Student> {
   new  Student("Truong", "Nhon"),
   new Student("John", "Don"),
   new Student("Hoang", "Hiep"),
   new Student("Trinh", "Tam"),
   new Student("Ho", "Duy")
};
foreach (Student student in students)
{
    Console.WriteLine(student.GetFullName());
}