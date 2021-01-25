using System;
using System.Collections.Generic;
using System.Text;

namespace _03.AnimalHierarchy
{
    class Frog : Animal
    {
        private static List<Frog> frogs = new List<Frog>();
        public Frog(string _name, int _age = 0, string _sex = "undefined") : base(_name, _age, _sex)
        {
            frogs.Add(this);
        }

        public new string ProduceSound()
        {
            return "Croak";
        }

        public new static double AverageAge()
        {
            if (frogs.Count == 0)
            {
                return 0;
            }

            double sumOfAges = 0;

            foreach (var frog in frogs)
            {
                sumOfAges += frog.age;
            }

            return Math.Round(sumOfAges / frogs.Count, 2);
        }

        public override string ToString()
        {
            return name + " is " + age + " year old frog." + ((sex == "female") ? "She" : "He") + " say '" + ProduceSound() + "'.";
        }
    }
}
