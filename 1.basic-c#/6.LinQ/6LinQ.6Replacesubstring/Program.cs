class Program
{

    public static void Main()
    {
        string[] strings = { "learn", "deal", "day" };
        var selectedStrings = strings.Where(x => x.Contains("ea")).Select(x => x.Replace("ea", "*")).ToList();
        foreach (string s in selectedStrings)
            Console.WriteLine(s);
    }

}
