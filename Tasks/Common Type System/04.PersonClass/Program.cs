using System;

namespace _04.PersonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person("Ivan Petrov Ivanov", 27);
            Person secondPerson = new Person("Georgi Petkov Anastasov");
            Console.WriteLine(firstPerson.ToString());
            Console.WriteLine(secondPerson.ToString());
        }
    }
}
