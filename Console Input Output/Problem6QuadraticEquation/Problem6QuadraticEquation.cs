namespace Problem6QuadraticEquation
{
    using System;

    public class Problem6QuadraticEquation
    {
        public static void Main()
        {
            // Write a program that reads the coefficients a, b and c of a quadratic equation
            // ax2 + bx + c = 0 and solves it (prints its real roots).
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            double d = (b * b) - (4 * a * c);
            if (d < 0)
            {
                Console.WriteLine("The quadratic equation does not have real roots");
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("The quadratic equation has one real root x = {0}", x);
            }
            else
            {
                double x1 = (-b - Math.Sqrt(d)) / (2 * a);
                double x2 = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("The quadratic equation has two real roots x1 = {0} and x2 = {1}", x1, x2);
            }
        }
    }
}