
class Program
{
    public static void Main(string[] args)
    {
        Customer customer = new Customer("Nhon", "Nhon@gmail.com", 10);
        System.Console.WriteLine(customer.ToString());
        customer.AddFunds(10);
        System.Console.WriteLine(customer.ToString());
        
        if(customer.CanAfford(5))
            customer.MakePurchased(5);
        System.Console.WriteLine(customer.ToString());

        if(customer.CanAfford(5))
            customer.MakePurchased(16);
        System.Console.WriteLine(customer.ToString());

        Customer negativeCustomer = new Customer("Nhon", "Nhon@gmail.com", -10);
    }
}