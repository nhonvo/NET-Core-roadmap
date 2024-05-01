class Program
{
    public static string Concatenate(string a, string b) => Concatenate(a, b);
    public static string Concatenate(string a, string b, string c) => Concatenate(a, b, c);

    public static void Main(string[] args)
    {
        string a = "truong"; string b = "Nhon"; string c = "dotnet";
        Console.WriteLine(Concatenate(a, b));
        Console.WriteLine(Concatenate(a, b, c));
    }
}