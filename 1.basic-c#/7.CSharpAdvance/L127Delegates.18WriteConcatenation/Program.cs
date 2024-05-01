class Program
{

    public delegate void ConcatenationStringDelegate(string x, string y);

    public static void ConcatenationString(string x, string y)
    {
        Console.WriteLine(x + y);
    }

    public static void Main(string[] args)
    {
        ConcatenationStringDelegate concatenationString = ConcatenationString;
        ConcatenationString("truong ", "nhon");
    }

}