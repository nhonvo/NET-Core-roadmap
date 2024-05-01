class Program
{

    public static int Sum(int number)
    {
        if (number == 0)
        {
            return 0;
        }
        return number + Sum(number - 1);
    }
    public static float Average(int number, int sum)
    {

        return (float)sum / number;
    }
    public static void Main(string[] args)
    {
        int number = 6;
        int sum = Sum(number);
        System.Console.WriteLine(Average(number, sum));
    }
}