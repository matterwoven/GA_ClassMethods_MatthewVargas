namespace GA_ClassMethods_MatthewVargas
{
    internal class Program
    {
        //Matthew Vargas
        //1/19/2024

        static void Main(string[] args)
        {
            List<int> stuGrades = new List<int> {  40, 43, 89, 81, 95  };

            Student schStudent = new Student("Will", stuGrades);

            schStudent.AddGrade(78);
            schStudent.AddGrade(200); //like the premade code, to test for abnormalities
            schStudent.AddGrade(20);

            schStudent.DisplayAllGrades();

            schStudent.GetGrade();

            schStudent.DisplayStudentInfo();

            List<Student> randomStudents = GenerateRandomStudents();

            randomStudents.Add(schStudent);

            foreach (Student student in randomStudents)
            {
                student.DisplayStudentInfo();
            }


            Console.WriteLine("Hello, World!");
        }

        static List<Student> GenerateRandomStudents()
        {

            List<Student> students = new List<Student>();

            Random random = new Random();

            for (int i = 1; i <= 5; i++)
            {
                Student student = new Student ($"Student{i}");

                for (int j = 0; j < 5; j++)
                {
                    student.ExamScores.Add(random.Next(0, 101));                
                }

                students.Add(student);
            }

            return students;
        }


    }
}
