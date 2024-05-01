class Program
{
    public static bool CheckStringContainLetterA(string text) 
        => text.ToUpper().Contains('A');
    public static void Main()
    {
        Predicate<string> checkStringContainLetterAPredicate = CheckStringContainLetterA;
        string text = "truong nhona";
        System.Console.WriteLine(CheckStringContainLetterA(text));

    }
}