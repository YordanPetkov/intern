using System;
using System.Collections.Generic;
using System.Text;

namespace _01.SchoolClasses
{
    class Teacher : Person
    {
        private List<Discipline> disciplines = new List<Discipline>();

        public Teacher(string _name)
        {
            name = _name;
        }

        public void AddDiscipline(Discipline newDiscipline)
        {
            disciplines.Add(newDiscipline);
        }

        public override string ToString()
        {
            string teacherInformation = "";
            teacherInformation += name + "\n\t\tDisciplines : ";

            foreach (var discipline in disciplines)
            {
                string disciplineInformation = discipline.ToString();
                teacherInformation += "\n\t\t" + disciplineInformation;
            }

            return teacherInformation;
        }
    }
}
