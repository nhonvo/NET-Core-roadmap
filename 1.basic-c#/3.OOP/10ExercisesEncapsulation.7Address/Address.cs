public class Address
{
    private string Street;
    private string City;
    private string State;
    private int ZipCode;

    public string GetStreet()
    {
        return Street;
    }

    public void SetStreet(string street)
    {
        Street = street;
    }

    public string GetCity()
    {
        return City;
    }

    public void SetCity(string city)
    {
        City = city;
    }

    public string GetState()
    {
        return State;
    }

    public void SetState(string state)
    {
        State = state;
    }

    public int GetZipCode()
    {
        return ZipCode;
    }

    public void SetZipCode(int zipCode)
    {
        ZipCode = zipCode;
    }

}
