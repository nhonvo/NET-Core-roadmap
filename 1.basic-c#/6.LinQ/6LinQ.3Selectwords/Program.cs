class Program
{

    public static void Main()
    {
        List<string> words = new List<string> { "alabam", "am", "balalam", "tara", "", "a", "axeliam", "39yo0m", "trol" };

        var selectedWords = words.Where(s => s.StartsWith("a")).Where(s => s.EndsWith("m"));

        foreach (var word in selectedWords)
        {
            Console.Write($"{word}, "); 
        }
    }

}
