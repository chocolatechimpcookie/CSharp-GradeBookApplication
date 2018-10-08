using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
  public class StandardGradeBook : BaseGradeBook
  {
    //constructor
    public StandardGradeBook(string name, bool isweighted) : base(name, isweighted)
    {
      Type = GradeBookType.Standard;
    }
  }
}
