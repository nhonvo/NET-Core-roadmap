public abstract class Person
{
    public Person()
    {
        
    }
    private string Name { get; set; }
    private int HealthyNumber { get; set; }
    public virtual void Walking()
    {
        HealthyNumber = 10;
    }
    public virtual void Breathing()
    {
        HealthyNumber += 10;
    }
}
