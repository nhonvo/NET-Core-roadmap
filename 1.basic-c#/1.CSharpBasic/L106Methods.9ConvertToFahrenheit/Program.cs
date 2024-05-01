class Program
{

    public static double ConvertToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }


    public static void Main(string[] args)
    {
        double celsius = 35;
        System.Console.WriteLine(ConvertToFahrenheit(celsius));
    }
}