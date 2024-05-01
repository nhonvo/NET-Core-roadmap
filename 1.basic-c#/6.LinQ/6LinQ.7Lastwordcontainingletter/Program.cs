class Program
{

    public static void Main()
    {

        string[] vehicles = { "plane", "ferry", "car", "bike" };
        var selectedVehicles = vehicles.Order().FirstOrDefault(x => x.Contains('e'));
        Console.WriteLine(selectedVehicles);
    }

}
