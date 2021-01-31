using System;
using System.Collections.Generic;
using System.Text;

namespace _03.AnimalHierarchy
{
    class Dog : Animal
    {
        private static List<Dog> dogs = new List<Dog>();
        public Dog(string _name, int _age = 0, string _sex = "undefined") : base(_name, _age, _sex)
        {
            dogs.Add(this);
        }

        public new string ProduceSound()
        {
            return "Bark";
        }

        public new static double AverageAge()
        {
            if(dogs.Count == 0)
            {
                return 0;
            }

            double sumOfAges = 0;

            foreach (var dog in dogs)
            {
                sumOfAges += dog.age;
            }

            return Math.Round(sumOfAges / dogs.Count, 2);
        }

        public override string ToString()
        {
            return name + " is " + age + " year old dog." + ((sex == "female") ? "She" : "He") + " say '" + ProduceSound() + "'.";
        }
    }
}
