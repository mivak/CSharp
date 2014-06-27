namespace Trapezoids
{
    using System;

    public class Trapezoids
    {
        public static void Main()
        {
            // Write an expression that calculates trapezoid's area by given sides a and b and height h.
            Console.Write("side a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("side b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("height h = ");
            double height = double.Parse(Console.ReadLine());

            double area = (a + b) * height / 2;
            Console.WriteLine("Area = {0}", area);
        }
    }
}