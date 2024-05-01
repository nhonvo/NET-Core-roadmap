class Program
{
    /// <summary>
    /// convert celsius to fahrenheit
    /// </summary>
    /// <param name="celsius"></param>
    /// <returns></returns>
    public static double ConvertToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }


    public static void Main(string[] args)
    {
        double celsius = 25;
        System.Console.WriteLine(ConvertToFahrenheit(celsius));
    }
}