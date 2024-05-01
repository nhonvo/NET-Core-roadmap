class Program
{

    public static void DeclareStringArray(string[] fruits)
    {
        foreach (var item in fruits)
        {
            Console.Write("{0} ", item);
        }
    }
    private static void Main(string[] args)
    {
        string[] fruits = { "banana", "apple", "cherry", "date", "elderberry" };
        
        DeclareStringArray(fruits);
    }
}