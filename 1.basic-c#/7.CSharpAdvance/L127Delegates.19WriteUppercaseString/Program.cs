class Program
{
    public delegate string ConvertStringToUpperDelegate(string x);

    public static string ConvertStringToUpper(string x)
    {
        return x.ToUpper();
    }

    public static void Main(string[] args)
    {
        ConvertStringToUpperDelegate convertStringToUpperCase = ConvertStringToUpper;
        Console.WriteLine(convertStringToUpperCase("truong nhon"));
    }
}