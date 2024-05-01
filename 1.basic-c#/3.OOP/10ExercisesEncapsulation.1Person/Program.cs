namespace _10ExercisesEncapsulation._1Person
{
    class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.SetName("nhon");
            person.SetAge(1);
            Console.WriteLine("{0} {1}", person.GetName(), person.GetAge());
        }
    }
}