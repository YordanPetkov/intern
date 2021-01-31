using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StudentsAndWorkers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstNames = { "Petar", "Ivan", "Pavel", "Yordan" , "Georgi" , "Samuil" , "Borislav", "Teodor", "Kiril", "Miro"};
            string[] lastNames = { "Petkov", "Todorov" , "Spasov", "Ivanov", "Petrov", "Georgiev", "Hristov", "Qnev", "Toshev", "Manev"};
            List<Student> students = new List<Student>();
            List<Worker> workers = new List<Worker>();
            Random randomIndex = new Random();

            for (int i = 0; i < 10; i++)
            {
                string randomFirstName = firstNames[randomIndex.Next(firstNames.Length)];
                string randomLastName = lastNames[randomIndex.Next(lastNames.Length)];
                double randomGrade = Math.Round(randomIndex.NextDouble() * 4 + 2, 2);
                students.Add(new Student(randomFirstName, randomLastName, randomGrade));
            }

            for (int i = 0; i < 10; i++)
            {
                string randomFirstName = firstNames[randomIndex.Next(firstNames.Length)];
                string randomLastName = lastNames[randomIndex.Next(lastNames.Length)];
                double randomWeekSalary = Math.Round(randomIndex.NextDouble() * 1000 + 0, 2);
                double randomWorkHoursPerDay = Math.Round(randomIndex.NextDouble() * 8 + 4, 2);
                Worker tempWorker = new Worker(randomFirstName, randomLastName);
                tempWorker.WeekSalary = randomWeekSalary;
                tempWorker.WorkHoursPerDay = randomWorkHoursPerDay;
                workers.Add(tempWorker);
            }

            students = students.OrderBy(student => student.Grade).ToList();
            Console.WriteLine("Students :");

            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }

            workers = workers.OrderBy(worker => worker.MoneyPerHour()).ToList();
            Console.WriteLine("Workers :");

            foreach (var worker in workers)
            {
                Console.WriteLine(worker.ToString());
            }

            
            List<Human> humans = students.Cast<Human>()
            .Concat(workers)
            .ToList();
            humans = humans.OrderBy(human => human.ToString()).ToList();
            Console.WriteLine("Humans :");

            foreach (var human in humans)
            {
                Console.WriteLine(human.ToString());
            }
        }
    }
}
