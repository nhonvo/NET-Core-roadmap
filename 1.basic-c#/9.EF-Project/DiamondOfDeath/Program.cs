class Program
{
    public void Main(string[] args)
    {
        C c = new C();
        c.Print();
    }
}

public interface IA
{
    void Print();
}
public interface IB
{
    void Print();
}
class C : IA, IB
{
    public void Print()
    {
        System.Console.WriteLine("hehe");
    }
}