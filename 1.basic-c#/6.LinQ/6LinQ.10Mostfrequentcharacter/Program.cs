class Program
{

    public static void Main()
    {
        string strings = "panda";
        char selectedCharacter = strings.GroupBy(x => x).OrderByDescending(c=>c.Count()).First().Key;
        Console.WriteLine(selectedCharacter);

    }

}
