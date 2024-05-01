class Customer
{
    public string Name { get; set; }
    public string Email { get; set; }
    private double _AccountBalance;
    public double AccountBalance
    {
        get { return _AccountBalance; }
        private set
        {
            _AccountBalance = value > 0 ? value :
            throw new ArgumentOutOfRangeException("Account can not be negative");
        }
    }
    public Customer()
    {

    }

    public Customer(string name, string email, double accountBalance)
    {
        Name = name;
        Email = email;
        AccountBalance = accountBalance;
    }
    public double AddFunds(double amount)
    {
        return AccountBalance += amount;
    }
    public double MakePurchased(double amount)
    {
        return AccountBalance -= amount;
    }
    public bool CanAfford(double amount)
    {
        if (AccountBalance - amount >= 0)
            return true;
        return false;
    }
    public string ToString()
    {
        return Name + " " + Email + " (" + AccountBalance + ")";
    }
}