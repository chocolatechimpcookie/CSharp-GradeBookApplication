using GradeBook.Enums;
using System;

namespace GradeBook.GradeBooks
{
  public class RankedGradeBook : BaseGradeBook
  {
    public RankedGradeBook(string name) : base(name)
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
        if (averageGrade >= 90)
            return 'A';
        else if (averageGrade >= 80)
            return 'B';
        else if (averageGrade >= 70)
            return 'C';
        else if (averageGrade >= 60)
            return 'D';
        else
            return 'F';
      }
    }



  }

}
