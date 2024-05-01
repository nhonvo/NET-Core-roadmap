class Student : Person
{
    public Student()
    {
        
    }
    private int Age { get; set; }
    public override void Walking()
    {
        Age -= 10;
    }
}