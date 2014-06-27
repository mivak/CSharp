namespace Problem3CirclePerimeterAndArea
{
    using System;
    
    public class Problem3CirclePerimeterAndArea
    {
        public static void Main()
        {
            // Write a program that reads the radius r of a circle and prints its perimeter and area
            // formatted with 2 digits after the decimal point.
            Console.Write("Please enter the value of the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;

            Console.WriteLine("perimeter = {0:F2}\narea = {1:F2}", perimeter, area);
        }
    }
}