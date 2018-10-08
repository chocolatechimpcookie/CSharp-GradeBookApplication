using GradeBook.Enums;
using System;
using System.Linq;

namespace GradeBook.GradeBooks
{
  public class RankedGradeBook : BaseGradeBook
  {
    public RankedGradeBook(string name, bool isweighted) : base(name, isweighted)
    {
      Type = GradeBookType.Ranked;
    }
    public override char GetLetterGrade(double averageGrade)
    {
      if(Students.Count < 5)
      {
        throw new InvalidOperationException("Minimum of 5 students needed");

      }
      else
      {
        // the grades here are being determined by whom got the largest grades

        var threshold = (int)Math.Ceiling(Students.Count * 0.2);
        // how many students I must score lower than to drop a letter grade
        // rounded and turned to integer

        var grades = Students.OrderByDescending(e => e.AverageGrade).Select(e => e.AverageGrade).ToList();
        // -> grades ordered by descending, linq to order students
        // -> order by average grade
        // -> select selects only the average grade and not the whole student object
        // -> makes it a list

        // - 1, index starts at 0, how many students you have to go down for letter grade to change
        if (grades[threshold -1] <= averageGrade)
            return 'A';
        //twice what we need to drop one letter grade so two are dropped
        else if (grades[(threshold*2)-1] <= averageGrade)
            return 'B';
        else if (grades[(threshold*3)-1] <= averageGrade)
            return 'C';
        else if (grades[(threshold*4)-1] <= averageGrade)
            return 'D';
        else
            return 'F';
      }
    }
    public override void CalculateStatistics()
    {
      if (Students.Count < 5)
      {
        Console.WriteLine("Ranked grading requires at least 5 students with " +
        "grades in order to properly calculate a student's overall grade.");
      }
      else
      {
        base.CalculateStatistics();
      }
    }
    public override void CalculateStudentStatistics(string name)
    {
      if(Students.Count < 5)
      {
        Console.Write("Ranked grading requires at least 5 students with grades"
        + " in order to properly calculate a student's overall grade.");
      }
      else
      {
        base.CalculateStudentStatistics(name);
      }
    }


  }

}
