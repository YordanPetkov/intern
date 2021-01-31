using System;
using System.Collections.Generic;
using System.Text;

namespace _01.SchoolClasses
{
    class Class
    {
        private List<Teacher> teachers = new List<Teacher>();
        private string textIdentifier;

        public Class(string _textIdentifier)
        {
            textIdentifier = _textIdentifier;
        }

        public void AddTeacher(Teacher newTeacher)
        {
            teachers.Add(newTeacher);
        }

        public override string ToString()
        {
            string classInformation = "";
            classInformation += textIdentifier + "\n\tTeachers:";

            foreach (var teacher in teachers)
            {
                string teacherInformation = teacher.ToString();
                classInformation += "\n\t" + teacherInformation;
            }

            return classInformation;
        }
    }
}
