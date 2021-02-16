using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Exceptions_Homework
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<Exam> Exams { get; set; }

        public Student(string firstName, string lastName, IList<Exam> exams = null)
        {
            try
            {
                this.FirstName = firstName ?? throw new Exception("Invalid first name!");
                this.LastName = lastName ?? throw new Exception("Invalid last name!");
                this.Exams = exams;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public IList<ExamResult> CheckExams()
        {
            try
            {
                if (this.Exams == null)
                {
                    throw new Exception("The student has no exams!");
                }

                if (this.Exams.Count == 0)
                {
                    throw new Exception("The student has no exams!");
                }

                IList<ExamResult> results = new List<ExamResult>();
                for (int i = 0; i < this.Exams.Count; i++)
                {
                    results.Add(this.Exams[i].Check());
                }

                return results;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            
        }

        public double CalcAverageExamResultInPercents()
        {
            try
            {
                if (this.Exams == null)
                {
                    throw new Exception("Missing exams");
                }

                if (this.Exams.Count == 0)
                {
                    throw new Exception("The student has no exams!");
                }

                double[] examScore = new double[this.Exams.Count];
                IList<ExamResult> examResults = CheckExams();
                for (int i = 0; i < examResults.Count; i++)
                {
                    examScore[i] =
                        ((double)examResults[i].Grade - examResults[i].MinGrade) /
                        (examResults[i].MaxGrade - examResults[i].MinGrade);
                }

                return examScore.Average();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
    }
}
