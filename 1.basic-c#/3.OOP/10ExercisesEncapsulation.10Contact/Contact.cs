public class Contact
{
    private string Name;
    private string Email;
    private int Phone;

    public string GetName()
    {
        return Name;
    }

    public void SetName(string name)
    {
        Name = name;
    }

    public string GetEmail()
    {
        return Email;
    }

    public void SetEmail(string email)
    {
        Email = email;
    }

    public int GetPhone()
    {
        return Phone;
    }

    public void SetPhone(int phone)
    {
        Phone = phone;
    }
}