public class Program
{
    private static void Main(string[] args)
    {
        Employee employee = new Employee();
        employee.SetName("Truong Nhon");
        employee.SetSalary(1000000);
        Console.WriteLine(employee.GetName() + " " + employee.GetSalary());
    }

}