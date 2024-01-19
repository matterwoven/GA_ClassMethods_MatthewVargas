//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

     // Greened out for no conflicts, this was the code made before I pasted, as I was unable to see what was making the double show up in console, no need to debug, just wanted to show I did the work

//namespace GA_ClassMethods_MatthewVargas
//{
//internal class Student
//{
//
  //  public string Name { get; set; }
  // public List<int> ExamScores { get; private set; }

  //  public Student(string name)
  //  {
  //      Name = name;
  //      ExamScores = new List<int>();
  //  }

  //  public Student(string name, List<int> examScores)
  //  {
  //      Name = name;
  //      ExamScores = examScores;
  //  }

  //  public double CalculateAverageScore()       //
  //  {
  //      if (ExamScores.Count == 0)
  //      {
  //          return 0;
  //      }
  //      int totalScore = 0;
  //      foreach (int score in ExamScores)
  //      {
  //          totalScore += score;
  //      }

  //     return (double)totalScore / ExamScores.Count;

  //  }

  //  public char GetGrade()
  //  {
  //      double averageScore = CalculateAverageScore();

  //      if (averageScore >= 90)
  //      {
  //          return 'A';
  //      }
  //      else if (averageScore >= 80)
  //      {
  //          return 'B';
  //      }
  //      else if (averageScore >= 70)
  //      {
  //          return 'C';
  //      }
  //      else if (averageScore >= 60)
  //      {
  //          return 'D';
  //      }
  //      else
  //      {
  //          return 'F';
  //      }
  //  }

  //   public void DisplayStudentInfo()
  //  {
  //      Console.WriteLine($"Student Name: {Name}");
  //      Console.WriteLine($"Student Average Score is: {CalculateAverageScore}");
  //      Console.WriteLine($"Student Letter Grade is: {GetGrade()}");
  //  }
  //  public void AddGrade(int grade)
  //  {
  //      if (grade >= 0 && grade <= 100)
  //      {
  //          ExamScores.Add(grade);
  //          Console.WriteLine($"Added grade {grade} for {Name}");
  //      }   // ^Ooh nice system, will have to use this more in the future
  //      else
  //      {
  //          Console.WriteLine($"Invalid grade: {grade}. Grade must be between 0 and 100.");
  //      }
  //  }
  //  public void DisplayAllGrades()
  //  {
  //      Console.WriteLine($"Grades for {Name}:");
  //      for (int i = 0; i < ExamScores.Count; i++)
  //      {
  //          char letterGrade = GetLetterGrade(ExamScores[i]);
  //          Console.WriteLine($"Exam {i + 1}: {letterGrade} ({ExamScores[i]})");
  //      }
  //  }
  //  private char GetLetterGrade(int score)
  //  {
  //      if (score >= 90)
  //      {
  //          return 'A';
  //      }
  //      else if (score >= 80)
  //      {
  //          return 'B';
  //      }
  //     else if (score >= 70)
  //      {
  //          return 'C';
  //      }
  //      else if (score >= 60)
  //      {
  //          return 'D';
  //      }
  //      else
  //      {
  //          return 'F';
  //      }
  //  }
//}
//}
