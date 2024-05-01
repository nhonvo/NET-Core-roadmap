using L107Classes._2QuanLySinhVien;

class ListStudent
{
    List<Student> list = new List<Student>();
    public void Add(Student student)
    {
        //student.Input(student);       
        list.Add(student);
    }
    public void Remove(int id)
    {
        Student student = list.First(x => x.Id == id);
        list.Remove(student);
    }
    public void Update(Student updateStudent)
    {
        Student student = list.First(x => x.Id == updateStudent.Id);
        student.Id = updateStudent.Id;
        student.FirstName = updateStudent.FirstName;
        student.LastName = updateStudent.LastName;
    }
    public void Print()
    {
        foreach (var item in list)
        {
            item.Output(item);
        }
    }
}
