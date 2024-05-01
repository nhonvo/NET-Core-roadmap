using System.Runtime.CompilerServices;

class BankAccount
{
    private int AccountNumber { get; set; }
    private string AccountHolder { get; set; }
    private double Balance { get; set; } = 0;
    public BankAccount()
    {

    }
    public BankAccount(int accountNumber, string accountHolder, double balance)
    {
        this.AccountHolder = accountHolder;
        this.AccountNumber = accountNumber;
        this.Balance = balance;
    }
    public void Deposit(double money)
    {
        if (money > 0)
        {
            Balance = Balance + money;
        }
    }
    public bool Withdraw(double money)
    {
        if (money <= 0)
        {
            return false;
        }
        else if (Balance - money <= 0)
        {
            return false;
        }
        else
        {
            Balance = Balance - money;
            return true;
        }
    }
    public string Output() => $"{AccountNumber} {AccountHolder} {Balance}";

}
class Program
{
    public static void Main(string[] args)
    {
        BankAccount bankAccount = new BankAccount(123, "truong nhon", 0);
        System.Console.WriteLine(bankAccount.Output());
        bankAccount.Deposit(5);
        System.Console.WriteLine(bankAccount.Output());
        bankAccount.Withdraw(-5);
        System.Console.WriteLine(bankAccount.Output());

    }
}