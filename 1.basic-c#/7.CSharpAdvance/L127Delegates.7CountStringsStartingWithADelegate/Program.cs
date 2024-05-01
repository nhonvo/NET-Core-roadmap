class Program
{

    delegate int CountStringsStartingWithADelegate(string[] strings);
    public static int CountStringsStartingWithA(string[] strings)
    {
        int Count = 0;
        for (int i = 0; i < strings.Length; i++)
        {
            if (strings[i].StartsWith('a'))
            {
                Count++;
            }
        }
        return Count;
    }
    public static void Main()
    {
        CountStringsStartingWithADelegate count = CountStringsStartingWithA;
        int result = count(new string[] { "apple", "orange", "banana" });
        Console.WriteLine(result);

    }

}