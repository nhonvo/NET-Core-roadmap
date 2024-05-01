class HuyndaiCar : Car
{
    public HuyndaiCar(int age):base()
    {
        age = Age;
    }
    private int Age { get; set; }
    protected override void Drive()
    {
        Age++;
    }
}