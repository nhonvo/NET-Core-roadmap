﻿class Program
{

    public static void Main()
    {
        var values = new List<string> { "Hi", "Meow", "Hello", "Meow", "Hi!", "Meow", "Hi", "Bye" };
        var uniqueValues = values
                .GroupBy(x => x)
                .Where(x => x.Count() == 1)
                .Select(x => x.Key)
                .ToList();

        foreach (var value in uniqueValues)
        {
            Console.WriteLine($"{value}"); 
        }
    }

}
