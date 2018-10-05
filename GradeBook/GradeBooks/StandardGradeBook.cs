using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
  public class StandardGradeBook : BaseGradeBook
  {
    //constructor
    public StandardGradeBook(string name) : base(name)
    {
      Type = GradeBookType.Standard;
    }
  }
}
