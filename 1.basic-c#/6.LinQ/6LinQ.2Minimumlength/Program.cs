class Program
{

    public static void Main()
    {
        List<string> computers = new List<string> { "computer", "usb", "ram" };
        var ComputersSelected = computers.Where(s => s.Length > 5).ToList().Select(s => s.ToUpper());
        foreach (var computer in ComputersSelected)
        {
            Console.WriteLine("{0} ", computer);
        }
    }

}
