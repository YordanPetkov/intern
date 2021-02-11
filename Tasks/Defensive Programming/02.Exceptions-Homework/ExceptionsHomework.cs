using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Exceptions_Homework
{
    class ExceptionsHomework
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            try
            {
                if(arr == null)
                {
                    throw new Exception("Array is empty.");
                }
                if(startIndex >= arr.Length || startIndex < 0)
                {
                    throw new Exception("Invalid start index.");
                }
                if(startIndex + count >= arr.Length || count < 0)
                {
                    throw new Exception("Invalid count.");
                }
                List<T> result = new List<T>();
                for (int i = startIndex; i < startIndex + count; i++)
                {
                    result.Add(arr[i]);
                }
                return result.ToArray();
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                return new List<T>().ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<T>().ToArray();
            }
        }

        public static string ExtractEnding(string str, int count)
        {
            try
            {
                if (count > str.Length)
                {
                    throw new Exception("Invalid count!");
                }

                StringBuilder result = new StringBuilder();
                for (int i = str.Length - count; i < str.Length; i++)
                {
                    result.Append(str[i]);
                }
                return result.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "";
            }
        }

        public static bool CheckPrime(int number)
        {
            try
            {
                if(number < 2)
                {
                    throw new Exception("Invalid number!");
                }

                for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
                {
                    if (number % divisor == 0)
                    {
                        Console.WriteLine("Number is not prime.");
                        return true;
                    }
                }
                Console.WriteLine("Number is prime.");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        static void Main()
        {
            var substr1 = Subsequence(new int[0], 2, 3);
            Console.WriteLine(substr1);

            var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(String.Join(" ", subarr));

            var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(String.Join(" ", allarr));

            var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(String.Join(" ", emptyarr));

            Console.WriteLine(ExtractEnding("I love C#", 2));
            Console.WriteLine(ExtractEnding("Nakov", 4));
            Console.WriteLine(ExtractEnding("beer", 4));
            Console.WriteLine(ExtractEnding("Hi", 100));

            CheckPrime(23);
            CheckPrime(33);
                
            List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}
