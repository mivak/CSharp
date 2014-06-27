namespace PointInACircle
{
    using System;

    public class PointInACircle
    {
        public static void Main()
        {
            // Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2).
            double radius = 2;
            double centerX = 0;
            double centerY = 0;
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());
            bool isInTheCircle;

                // The formula includes centerX and centerY. In our case they are equal to zero and we can
                // miss them. Then the expression would look like:
                // if (x * x + y * y <= radius * radius)
            if ((x - centerX) * (x - centerX) + (y - centerY) * (y - centerY) <= radius * radius)
            {
                isInTheCircle = true;
            }
            else
            {
                isInTheCircle = false;
            }

            Console.WriteLine("Is the point in the circle? {0}", isInTheCircle);
        }
    }
}