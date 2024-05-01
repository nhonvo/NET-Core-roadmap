using FinalStudentManagement.LogicTier;


namespace FinalStudentManagement.Presentation
{
    public class ScorePresentation
    {
        private readonly ScoreManagement _scoreManagement;

        public ScorePresentation()
        {
            _scoreManagement = new ScoreManagement();
        }

        public async Task Add()
        {
            Console.Write("Enter the ID of the student: ");
            int studentId = int.Parse(Console.ReadLine()!);

            Console.Write("Enter the ID of the subject: ");
            int subjectId = int.Parse(Console.ReadLine()!);

            Console.Write("Enter the score value: ");
            int scoreValue = int.Parse(Console.ReadLine()!);

            Score newScore = new Score()
            {
                StudentID = studentId,
                SubjectID = subjectId,
                ScoreValue = scoreValue
            };

            await _scoreManagement.Add(newScore);
            Console.WriteLine("Score added successfully.");
        }

        public async Task ViewAll()
        {
              Console.Write("Enter the student ID of the student: ");
            int studentID = int.Parse(Console.ReadLine()!);

            var scores = await _scoreManagement.GetAll(studentID);
            Console.WriteLine("List of all scores:");
            foreach (var s in scores)
            {
                Console.WriteLine($"ID: {s.ID}, StudentID: {s.StudentID}, SubjectID: {s.SubjectID}, ScoreValue: {s.ScoreValue}");
            }
        }

        public async Task Update()
        {
            Console.Write("Enter the ID of the score to update: ");
            int id = int.Parse(Console.ReadLine()!);

            var oldScore = await _scoreManagement.GetById(id);

            if (oldScore == null)
            {
                Console.WriteLine("Score not found.");
            }
            else
            {
                Console.Write("Enter the new student ID (old value = {0}): ", oldScore.StudentID);
                int studentId = int.Parse(Console.ReadLine()!);

                Console.Write("Enter the new subject ID (old value = {0}): ", oldScore.SubjectID);
                int subjectId = int.Parse(Console.ReadLine()!);

                Console.Write("Enter the new score value (old value = {0}): ", oldScore.ScoreValue);
                int scoreValue = int.Parse(Console.ReadLine()!);

                Score updatedScore = new Score()
                {
                    ID = id,
                    StudentID = studentId,
                    SubjectID = subjectId,
                    ScoreValue = scoreValue
                };

                await _scoreManagement.Update(updatedScore);
                Console.WriteLine("Score updated successfully.");
            }
        }

        public async Task Delete()
        {
            Console.WriteLine("Enter the ID of the score to delete:");
            int id = int.Parse(Console.ReadLine()!);

            Score scoreToDelete = await _scoreManagement.GetById(id);
            if (scoreToDelete == null)
            {
                Console.WriteLine("Score not found.");
                return;
            }

            await _scoreManagement.Delete(id);
            Console.WriteLine("Score deleted successfully.");
        }
    }
}
