namespace SurfaceOfATriangle
{
    using System;

    public class SurfaceOfATriangle
    {
        public static void Main()
        {
            // Write methods that calculate the surface of a triangle by given:
            // Side and an altitude to it; Three sides; Two sides and an angle between them.
            // Use System.Math.
            Console.WriteLine("Please choose one of the methods to calculate the surface of a triangle");
            Console.WriteLine("To use a side and an altitude to it enter 1\nTo use three sides enter 2\nTo use two sides and an angle between them enter 3");
            byte choice = byte.Parse(Console.ReadLine());
            double surface = 0;

            switch (choice)
            {
                case 1: Console.Write("Please enter the value of a side: ");
                    double side = double.Parse(Console.ReadLine());
                    Console.Write("Please enter the value of the altitude to the side: ");
                    double altitude = double.Parse(Console.ReadLine());
                    surface = SideAndAltitude(side, altitude);
                    Console.WriteLine("The surface of the triangle is: {0:F2}", surface);
                    break;
                case 2: Console.Write("Please enter the value of the first side: ");
                    double firstSide = double.Parse(Console.ReadLine());
                    Console.Write("Please enter the value of the second side: ");
                    double secondSide = double.Parse(Console.ReadLine());
                    Console.Write("Please enter the value of the thirdSide: ");
                    double thirdSide = double.Parse(Console.ReadLine());
                    surface = ThreeSides(firstSide, secondSide, thirdSide);
                    Console.WriteLine("The surface of the triangle is: {0:F2}", surface);
                    break;
                case 3: Console.Write("Please enter the value of the first side: ");
                    double sideOne = double.Parse(Console.ReadLine());
                    Console.Write("Please enter the value of the second side: ");
                    double sideTwo = double.Parse(Console.ReadLine());
                    Console.Write("Please enter the value of the angle between the two sides: ");
                    double angle = double.Parse(Console.ReadLine());
                    surface = TwoSidesAndAnAngle(sideOne, sideTwo, angle);
                    Console.WriteLine("The surface of the triangle is: {0:F2}", surface);
                    break;
            }
        }

        private static double TwoSidesAndAnAngle(double sideOne, double sideTwo, double angle)
        {
            double surface = sideOne * sideTwo * Math.Sin(angle / 180 * Math.PI) / 2;
            return surface;
        }

        private static double ThreeSides(double firstSide, double secondSide, double thirdSide)
        {
            double p = (firstSide + secondSide + thirdSide) / 2;
            double surface = Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));
            return surface;
        }

        private static double SideAndAltitude(double side, double altitude)
        {
            double surface = side * altitude / 2;
            return surface;
        }
    }
}