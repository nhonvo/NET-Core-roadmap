namespace _10ExercisesEncapsulation._1Person
{
    class Person
    {
        private string Name;
        private int Age;
        public string GetName() => Name;
        public void SetName(string name) => this.Name = name;
        public int GetAge() => Age;
        public void SetAge(int age) => this.Age = age;
       
    }
}