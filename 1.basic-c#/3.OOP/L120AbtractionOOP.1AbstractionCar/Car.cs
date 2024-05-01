public abstract class Car
{
    public Car()
    {
        
    }

    protected Car(string name, int wheels)
    {
        Name = name;
        Wheels = wheels;
    }

    private string Name { get; set; }
    private int Wheels { get; set; }
    protected virtual void Drive()
    {
        Wheels++;
    }
}
