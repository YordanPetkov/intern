using System;

namespace _01.SchoolClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Class classEleventhB = new Class("11b");
            Discipline math = new Discipline("Math", 40, 20);
            Discipline biology = new Discipline("Biology", 40, 5);
            Discipline physics = new Discipline("Physics", 42, 10);
            Discipline english = new Discipline("English", 40, 40);
            Student petar = new Student("Petar Georgiev", 21, classEleventhB);
            Student georgi = new Student("Georgi Ivanov", 6, classEleventhB);
            Teacher mariaPetrova = new Teacher("Maria Petrova");
            Teacher ivanPeshev = new Teacher("Ivan Peshev");
            mariaPetrova.AddDiscipline(math);
            mariaPetrova.AddDiscipline(physics);
            ivanPeshev.AddDiscipline(biology);
            ivanPeshev.AddDiscipline(english);
            classEleventhB.AddTeacher(mariaPetrova);
            classEleventhB.AddTeacher(ivanPeshev);
            Console.WriteLine(petar.ToString());
            Console.WriteLine(georgi.ToString());
        }
    }
}
