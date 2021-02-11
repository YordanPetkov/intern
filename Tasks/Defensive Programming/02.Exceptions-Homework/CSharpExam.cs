using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Exceptions_Homework
{
    public class CSharpExam : Exam
    {
        public int Score { get; private set; }

        public CSharpExam(int score)
        {
            try
            {
                if (score < 0)
                {
                    throw new NullReferenceException("Score must be positive.");
                }

                this.Score = score;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public override ExamResult Check()
        {
            try
            {
                if (Score < 0 || Score > 100)
                {
                    throw new InvalidOperationException("Invalid score.");
                }
                else
                {
                    return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
                return new ExamResult(0, 0, 100, "Exam results calculated by score.");
            }
        }
    }
}
