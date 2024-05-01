class ToyotaCar : Car
{
    public ToyotaCar(int price):base()
    {
        price = Price;
    }
    private int Price { get; set; }
    protected override void Drive()
    {
        Price++;
    }
}
