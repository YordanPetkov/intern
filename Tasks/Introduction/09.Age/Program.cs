using System;

namespace _09.Age
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birtday;
            DateTime now = DateTime.Today;
            DateTime afterTenYears = now.AddYears(10);
            birtday = Convert.ToDateTime(Console.ReadLine());

            int age, ageAfterTenYears;
            age = GetDifferenceInYears(birtday, now);
            ageAfterTenYears = GetDifferenceInYears(birtday, afterTenYears);
            Console.WriteLine(age);
            Console.WriteLine(ageAfterTenYears);
        }

        public static int GetDifferenceInYears(DateTime startDate,DateTime endDate)
        {
            int years = endDate.Year - startDate.Year;

            if (endDate.Month < startDate.Month || (endDate.Month == startDate.Month && endDate.Day < startDate.Day)) years--;
            return years;
        }
    }
}
