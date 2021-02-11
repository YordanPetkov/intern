using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompareAdvancedMaths
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
            double result = Math.Sqrt((double)float.MaxValue);
            DateTime endTime = DateTime.Now;
            double sqrtTimeForFloats = (endTime - startTime).TotalSeconds;

            startTime = DateTime.Now;
            result = Math.Sqrt(double.MaxValue);
            endTime = DateTime.Now;
            double sqrtTimeForDoubles = (endTime - startTime).TotalSeconds;

            startTime = DateTime.Now;
            result = Math.Sqrt((double)decimal.MaxValue);
            endTime = DateTime.Now;
            double sqrtTimeForDecimals = (endTime - startTime).TotalSeconds;

            
        }
    }
}
