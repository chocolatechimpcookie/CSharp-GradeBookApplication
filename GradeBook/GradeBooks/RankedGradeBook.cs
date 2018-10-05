namespace GradeBook.GradeBooks
{
  public class RankedGradeBook : BaseGradeBook
  {
    public RankedGradeBook : base(name)
    {
      Type = GradeBookType.Ranked;
    }
  }
}
