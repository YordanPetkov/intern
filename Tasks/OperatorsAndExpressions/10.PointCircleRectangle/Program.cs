using System;

namespace _10.PointCircleRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double circleX = 1, circleY = 1, circleR = 1.5;
            double recX = -1, recY = 1, recWidth = 6, recHeight = 2;
            double pointX, pointY;
            double distanceFromCircle;
            bool inCircle, inRectangle;

            pointX = double.Parse(Console.ReadLine());
            pointY = double.Parse(Console.ReadLine());

            distanceFromCircle = Math.Sqrt(Math.Pow(Math.Abs(pointX - circleX), 2) + Math.Pow(Math.Abs(pointY - circleY), 2));
            if (distanceFromCircle <= circleR) inCircle = true;
            else inCircle = false;

            if (pointX < recX || pointX > recX + recWidth || pointY > recY || pointY < recY - recHeight) inRectangle = false;
            else inRectangle = true;

            if (inCircle) Console.Write("inside circle ");
            else Console.Write("outside circle ");
            if (inRectangle) Console.WriteLine("inside rectangle");
            else Console.WriteLine("outside rectangle");
        }
    }
}
