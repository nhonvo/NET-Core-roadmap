class Program
{
    public static void Main(string[] args)
    {

        Shape[] shapes = new Shape[4];

        shapes[0] = new Circle(5);
        shapes[1] = new Circle(2);
        shapes[2] = new Rectangle(4, 6);
        shapes[3] = new Rectangle(6, 8);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine("Area: {0}",shape.GetArea());
            Console.WriteLine("Perimeter: {0}",shape.GetPerimeter());
            Console.WriteLine();
        }

    }

}
