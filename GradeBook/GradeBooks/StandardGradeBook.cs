namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool b): base(name, b)
        {
            Type = Enums.GradeBookType.Standard;                
        }
    }
}