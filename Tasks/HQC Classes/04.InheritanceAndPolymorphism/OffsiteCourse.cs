using System;
using System.Collections.Generic;
using System.Text;

namespace _04.InheritanceAndPolymorphism
{
    public class OffsiteCourse : Course
    {
        
        public string Town { get; set; }

        public OffsiteCourse(string name) : base(name)
        {
            this.Town = null;
        }

        public OffsiteCourse(string courseName, string teacherName) : base(courseName, teacherName)
        {
            this.Town = null;
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students) : base(courseName, teacherName, students)
        {
            this.Town = null;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());
            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }
            result.Append(" }");
            return result.ToString();
        }
    }
}
