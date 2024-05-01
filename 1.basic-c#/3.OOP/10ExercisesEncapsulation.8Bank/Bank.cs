public class Bank
{
    private List<Account> Accounts;
    private List<Customer> Customers;
    public Bank()
    {
        Accounts = new List<Account>();
        Customers = new List<Customer>();
    }
    public void AddAccount(Account account)
    {
        if (!Accounts.Contains(account))
        {
            Accounts.Add(account);
        }
    }
    public void RemoveAccount(Account account)
    {
        if (Accounts.Contains(account))
        {
            Accounts.Remove(account);
        }
    }

    public void AddCustomer(Customer customer)
    {
        if (!Customers.Contains(customer))
        {
            Customers.Add(customer);
        }
    }
    public void RemoveCustomer(Customer customer)
    {
        if (Customers.Contains(customer))
        {
            Customers.Remove(customer);
        }
    }
}
