using System;
using System.Collections.Generic;
using System.Text;

namespace _03.AnimalHierarchy
{
    class Cat : Animal
    {
        private static List<Cat> cats = new List<Cat>();
        public Cat(string _name, int _age = 0, string _sex = "undefined") : base(_name, _age, _sex)
        {
            cats.Add(this);
        }

        public new string ProduceSound()
        {
            return "Meow";
        }

        public new static double AverageAge()
        {
            if (cats.Count == 0)
            {
                return 0;
            }

            double sumOfAges = 0;

            foreach (var dog in cats)
            {
                sumOfAges += dog.age;
            }

            return Math.Round(sumOfAges / cats.Count, 2);
        }

        public override string ToString()
        {
            return name + " is " + age + " year old cat." + ((sex == "female") ? "She" : "He") + " say '" + ProduceSound() + "'.";
        }
    }
}
