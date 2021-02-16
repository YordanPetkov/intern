using System;

namespace Methods
{
    class Methods
    {
        static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new Exception("Sides should be positive.");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        static string SpellDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new Exception("Number should be between 0 and 9.");
            }
        }

        static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new Exception("Array of elements is empty.");
            }

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > elements[0])
                {
                    elements[0] = elements[i];
                }
            }

            return elements[0];
        }

        static void PrintAsNumber(object number, string format)
        {
            switch(format)
            {
                case "f":
                    Console.WriteLine("{0:f2}", number);
                    break;
                case "%":
                    Console.WriteLine("{0:p0}", number);
                    break;
                case "r":
                    Console.WriteLine("{0,8}", number);
                    break;
                default:
                    throw new Exception("Invalid format.");
            }
        }

        static double CalculateDistance(Point firstPoint, Point secondPoint, out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = (firstPoint.y == secondPoint.y);
            isVertical = (firstPoint.x == secondPoint.x);

            double distance = Math.Sqrt((secondPoint.x - firstPoint.x) * (secondPoint.x - firstPoint.x) +
                    (secondPoint.y - firstPoint.y) * (secondPoint.y - firstPoint.y));

            return distance;
        }

        static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(SpellDigit(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            Point firstPoint = new Point(3, -1);
            Point secondPoint = new Point(3, 2.5);

            Console.WriteLine(CalculateDistance(firstPoint, secondPoint, out bool horizontal, out bool vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov"};
            peter.OtherInfo = "From Sofia.";
            peter.BirthDay = new DateTime(1999, 12, 16);

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova"};
            stella.OtherInfo = "From Vidin, gamer, high results.";
            stella.BirthDay = new DateTime(1993, 11, 03);

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}

