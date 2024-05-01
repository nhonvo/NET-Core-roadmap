class Program
{
    /// <summary>
    /// Print to console and value variable
    /// </summary>
    /// <param name="name"></param>
    /// <param name="age"></param>
    public static void HelloWorld(string name, int age)
    {
        Console.WriteLine("Hello Mom!");
        Console.WriteLine($"My name's {name}");
        Console.WriteLine($"I'm {age} years old");
        Console.WriteLine("\tHello Mom!");
        Console.WriteLine("\nHello Mom!");
    }
    private static void Main(string[] args)
    {
        string name = "Nhơn";
        int age = 20;
        
        HelloWorld(name, age);
    }
}