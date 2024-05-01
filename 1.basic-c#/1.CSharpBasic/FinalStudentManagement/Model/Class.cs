public class Class
{
    public Class()
    {

    }
    public Class(int iD, string name, string description)
    {
        ID = iD;
        Name = name;
        Description = description;
    }

    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
