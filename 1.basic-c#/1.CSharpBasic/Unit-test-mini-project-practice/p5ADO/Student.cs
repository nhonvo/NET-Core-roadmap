using System.Xml.Linq;

namespace AdoSql
{
    class Student
    {
        public Student(int iD, string name, string email, int classID)
        {
            ID = iD;
            Name = name;
            Email = email;
            ClassID = classID;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int ClassID { get; set; }
    }
}