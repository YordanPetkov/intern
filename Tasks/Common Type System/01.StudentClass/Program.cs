using System;

namespace _01.StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[2];
            students[0] = new Student("Ivan Petrov Georgiev", "9910223598");
            students[1] = new Student("Petur Georgiev Petkov", "0049112209");
            students[0].setInformation("Ivan Vazov 5 Sofiq", "0889584277", "ivan.georgiev22@gmail.com");
            students[0].enrollStudent(2, Specialties.ComputerScience, Universities.SofiaUniversity, Faculties.MathAndInformatic);
            students[1].setInformation("Geo Milev N'55 Plovdiv", "0888553291", "petur_g_petkov@abv.bg");
            students[1].enrollStudent(1, Specialties.Law, Universities.TechnicalUniversity, Faculties.FacultyOfLaw);
            Console.WriteLine(students[0].ToString());
            Console.WriteLine(students[1].ToString());
            Console.WriteLine(students[0] == students[1]);
            Console.WriteLine(students[0] != students[1]);
            Console.WriteLine(students[0].Equals(students[1]));
            Console.WriteLine(students[0].GetHashCode());
            Console.WriteLine(students[1].GetHashCode());
            students[0].Clone(students[1]);
            Console.WriteLine(students[0].ToString());
            Console.WriteLine(students[1].ToString());
            Console.WriteLine(students[0] == students[1]);
            Console.WriteLine(students[0] != students[1]);
            Console.WriteLine(students[0].Equals(students[1]));
            Console.WriteLine(students[0].GetHashCode());
            Console.WriteLine(students[1].GetHashCode());
        }
    }
}
