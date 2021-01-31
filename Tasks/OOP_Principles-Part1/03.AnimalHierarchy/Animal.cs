using System;
using System.Collections.Generic;
using System.Text;

namespace _03.AnimalHierarchy
{
    abstract class Animal : ISound
    {
        protected int age;
        protected string name;
        protected string sex;

        public Animal(string _name, int _age, string _sex)
        {
            name = _name;
            age = _age;
            sex = _sex;
        }
        public string ProduceSound()
        {
            return "I'm Animal";
        }

        public static double AverageAge()
        {
            return Math.Round((Dog.AverageAge() + Frog.AverageAge() + Cat.AverageAge()) / 3, 2);
        }

        public override string ToString()
        {
            return name + " is " + age + " year old." + ((sex == "female") ?"She" : "He") + " say '" + ProduceSound() + "'.";
        }
    }
}
