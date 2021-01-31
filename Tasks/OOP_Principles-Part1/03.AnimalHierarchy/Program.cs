using System;

namespace _03.AnimalHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog[] dogs = { new Dog("Sharo", 4, "male"), new Dog("Mordi", 3, "male"), new Dog("Emma", 7, "female"), new Dog("Lucy", 2, "female") };
            Frog[] frogs = { new Frog("Choki", 1, "male"), new Frog("Lila", 3, "female"), new Frog("Kisha", 6, "female") };
            Cat[] cats = { new Cat("Mara", 9, "female"), new Cat("Pesho", 5, "male"), new Kitten("Djesa", 2), new Tomcat("Tom", 8) };

            foreach (var dog in dogs)
            {
                Console.WriteLine(dog.ToString());
            }

            foreach (var frog in frogs)
            {
                Console.WriteLine(frog.ToString());
            }

            foreach (var cat in cats)
            {
                Console.WriteLine(cat.ToString());
            }

            Console.WriteLine("Average age of dogs : {0}", Dog.AverageAge());
            Console.WriteLine("Average age of frogs : {0}", Frog.AverageAge());
            Console.WriteLine("Average age of cats : {0}", Cat.AverageAge());
        }
    }
}
