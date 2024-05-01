class Student : Person
{
    public Student()
    {
        
    }
    public int age { get; set; }
    public override void Walking()
    {
        healthyNumber -= 10;
    }
}