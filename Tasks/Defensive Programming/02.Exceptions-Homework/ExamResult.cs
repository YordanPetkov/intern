using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Exceptions_Homework
{
    public class ExamResult
    {
        public int Grade { get; private set; }
        public int MinGrade { get; private set; }
        public int MaxGrade { get; private set; }
        public string Comments { get; private set; }

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            try
            {
                if (grade < 0)
                {
                    throw new Exception("Grade can't be negative.");
                }
                if (minGrade < 0)
                {
                    throw new Exception("Minimal grade can't be negative.");
                }
                if (maxGrade <= minGrade)
                {
                    throw new Exception("Minimal grade must be lower than maximal grade.");
                }
                if (comments == null || comments == "")
                {
                    throw new Exception("Comments can't be empty.");
                }

                this.Grade = grade;
                this.MinGrade = minGrade;
                this.MaxGrade = maxGrade;
                this.Comments = comments;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
