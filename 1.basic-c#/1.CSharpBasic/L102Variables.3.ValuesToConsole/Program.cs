class Program
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <param name="age"></param>
    public static void ValueToConsole(string? name, int age)
    {

        Console.WriteLine("Enter Name: ");
        name = Console.ReadLine();
        Console.WriteLine("Enter Age: ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"My name's {name}");
        Console.WriteLine($"I'm {age} years old");
    }
    private static void Main(string[] args)
    {
        string name = "";
        int age = 0;
        ValueToConsole(name, age);
    }
}