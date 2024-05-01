public class Rectangle : Shape
{
    public double Height { get; set; }

    public double CalculateArea()
    {
        return Length * Width * Height;
    }

    public double CalculatePerimeter()
    {
        return 2 * (Length + Width + Height);
    }
}
