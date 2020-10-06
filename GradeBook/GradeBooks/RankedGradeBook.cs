using System;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool b): base(name, b)
        {
            Type = Enums.GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            if(Students.Count < 5)
            {
                throw new InvalidOperationException();
            }
            if(averageGrade >= 80.0)
            {
                return 'A';
            }
            else if(averageGrade < 80.0 && averageGrade >= 60.0)
            {
                return 'B';
            }
            else if(averageGrade < 60.0 && averageGrade >= 40.0)
            {
                return 'C';
            }
            else if(averageGrade < 40.0 && averageGrade >= 20.0)
            {
                return 'D';
            }
            return 'F';
        }
        public override void CalculateStatistics()
        {
            if(Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
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
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }
            else
            {
                base.CalculateStudentStatistics(name);
            } 
        }
    }
}