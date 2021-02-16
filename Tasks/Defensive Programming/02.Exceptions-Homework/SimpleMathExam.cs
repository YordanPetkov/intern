using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Exceptions_Homework
{
    public class SimpleMathExam : Exam
    {
        public int ProblemsSolved { get; private set; }

        public SimpleMathExam(int problemsSolved)
        {
            try
            {
                if (problemsSolved < 0)
                {
                    problemsSolved = 0;
                    throw new Exception("Count of solved problems can't be negative number.");
                }

                if (problemsSolved > 10)
                {
                    problemsSolved = 10;
                    throw new Exception("Count of solved problems can't be more than 10.");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                this.ProblemsSolved = problemsSolved;
            }
        }

        public override ExamResult Check()
        {
            try
            {
                if (ProblemsSolved == 0)
                {
                    return new ExamResult(2, 2, 6, "Bad result: nothing done.");
                }

                else if (ProblemsSolved == 1)
                {
                    return new ExamResult(4, 2, 6, "Average result: nothing done.");
                }

                else if (ProblemsSolved == 2)
                {
                    return new ExamResult(6, 2, 6, "Average result: nothing done.");
                }

                else
                {
                    throw new Exception("Invalid number of problems solved!");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new ExamResult(0, 0, 0, "Invalid number of problems solved!");
            }
        }
    }
}
