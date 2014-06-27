namespace Rectangles
{
    using System;
    
    public class Rectangles
    {
        public static void Main()
        {
            // Write an expression that calculates rectangle’s perimeter and area by given width and height.
            Console.Write("width = ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("height = ");
            double height = double.Parse(Console.ReadLine());

            double perimeter = 2 * (width + height);
            double area = width * height;

            Console.WriteLine("The perimeter of the rectangle is {0}", perimeter);
            Console.WriteLine("The area of the rectangle is {0}", area);
        }
    }
}