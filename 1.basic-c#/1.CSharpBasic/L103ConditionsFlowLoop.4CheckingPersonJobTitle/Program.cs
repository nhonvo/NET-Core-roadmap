class Program
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    public static void CheckingPersonJobTitle(string message)
    {

        switch (message)
        {
            case "Manager":
                Console.WriteLine("You are in charge");
                break;
            case "Employee":
                Console.WriteLine("You work for manager");
                break;
            case "Intern":
                Console.WriteLine("You are learning");
                break;
            default:
                Console.WriteLine("Not have this title");
                break;
        }
    }
    private static void Main(string[] args)
    {
        string message = "Manager";

        CheckingPersonJobTitle(message);
    }
}