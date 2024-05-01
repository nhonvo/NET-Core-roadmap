public class Order
{
    public int OrderNumber { get; set; }
    public Customer Customer{ get; set; }
    public int Total;

    public int GetOrderNumber()
    {
        return OrderNumber;
    }

    public void SetOrderNumber(int orderNumber)
    {
        OrderNumber = orderNumber;
    }

    public Customer GetCustomer()
    {
        return Customer;
    }

    public void SetCustomer(Customer customer)
    {
        Customer = customer;
    }

    public int GetTotal()
    {
        return Total;
    }

    public void SetTotal(int total)
    {
        Total = total;
    }
}