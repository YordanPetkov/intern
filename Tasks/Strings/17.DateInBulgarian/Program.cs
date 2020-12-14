using System;
using System.Collections.Generic;

namespace _17.DateInBulgarian
{
    class Program
    {
        static void Main(string[] args)
        {
            var bulgarianWeekDays = new Dictionary<string, string>();
            bulgarianWeekDays["Monday"] = "Понеделник";
            bulgarianWeekDays["Tuesday"] = "Вторник";
            bulgarianWeekDays["Wednesday"] = "Сряда";
            bulgarianWeekDays["Thursday"] = "Четвъртък";
            bulgarianWeekDays["Friday"] = "Петък";
            bulgarianWeekDays["Saturday"] = "Събота";
            bulgarianWeekDays["Sunday"] = "Неделя";
            string dateText = Console.ReadLine();
            string[] dateParts = dateText.Split('.', ' ', ':');
            int year = int.Parse(dateParts[2]);
            int month = int.Parse(dateParts[1]);
            int day = int.Parse(dateParts[0]);
            int hour = int.Parse(dateParts[3]);
            int minute = int.Parse(dateParts[4]);
            int second = int.Parse(dateParts[5]);
            DateTime date = new DateTime(year, month, day, hour, minute, second);
            date = date.AddHours(6.5);
            DayOfWeek weekday = date.DayOfWeek;
            Console.WriteLine("{0:dd.MM.yyyy HH:mm:ss} {1}", date, bulgarianWeekDays[weekday.ToString()]);
        }
    }
}
