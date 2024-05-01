namespace _10ExercisesEncapsulation._5Library
{
    public class Borrower
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public Borrower(int id, string name, string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }
    }
}