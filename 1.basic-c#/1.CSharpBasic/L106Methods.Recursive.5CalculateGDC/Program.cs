class Program
{
    public static int CalculateGDC(int First, int Second)
    {
        if (First == Second)
        {
            return First;
        }
        if (First < Second)
        {
            return CalculateGDC(First, Second - First);

        }
            return CalculateGDC(First -  Second, Second);
    }
    public static void Main(string[] args)
    {
        int First = 3;
        int Second = 2;
        System.Console.WriteLine(CalculateGDC(First, Second));
    }
}