public abstract class Person
{
    public Person()
    {
        
    }
    public string name { get; set; }
    public int healthyNumber { get; set; }
    public virtual void Walking()
    {
        healthyNumber = 10;
    }
    public virtual void Breathing()
    {
        healthyNumber += 10;
    }
}
