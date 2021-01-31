using System;
using System.Collections.Generic;
using System.Text;

namespace _01.SchoolClasses
{
    class Discipline
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string _name, int _numberOfLectures, int _numberOfExercises)
        {
            name = _name;
            numberOfLectures = _numberOfLectures;
            numberOfExercises = _numberOfExercises;
        }

        public override string ToString()
        {
            string disciplineInformation = "";
            disciplineInformation += name + ": Lectures : " + numberOfLectures + ", Exercises : " + numberOfExercises;
            return disciplineInformation;
        }
    }
}
