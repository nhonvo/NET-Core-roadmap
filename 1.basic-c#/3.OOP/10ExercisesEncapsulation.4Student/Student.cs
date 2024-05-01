public class Student
    {
        private string Name;
        private decimal GPA;

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public decimal GetGPA()
        {
            return GPA;
        }

        public void SetGPA(decimal gpa)
        {
            GPA = gpa;
        }
    }
