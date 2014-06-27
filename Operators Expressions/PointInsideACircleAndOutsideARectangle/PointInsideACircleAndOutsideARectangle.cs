namespace PointInsideACircleAndOutsideARectangle
{
    using System;

    public class PointInsideACircleAndOutsideARectangle
    {
        public static void Main()
        {
            // Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5)
            // and out of the rectangle R(top=1, left=-1, width=6, height=2). 
            double radius = 1.5;
            double centerX = 1;
            double centerY = 1;
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());
            bool isInTheCircle;
            bool outOfTheRectangle;

            if ((x - centerX) * (x - centerX) + (y - centerY) * (y - centerY) <= radius * radius)
            {
                isInTheCircle = true;
            }
            else
            {
                isInTheCircle = false;
            }

            if (x < -1 || x > 5 || y < -1 || y > 1)
            {
                outOfTheRectangle = true;
            }
            else
            {
                outOfTheRectangle = false;
            }

            if (outOfTheRectangle == true && isInTheCircle == true)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
 
            Console.WriteLine();
        }
    }
}