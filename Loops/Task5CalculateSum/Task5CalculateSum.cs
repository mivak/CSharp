namespace Task5CalculateSum
{
    using System;
    
    public class Task5CalculateSum
    {
        public static void Main()
        {
            // Write a program that, for a given two integer numbers n and x, calculates the sum
            // S = 1 + 1!/x + 2!/x2 + … + n!/xn. Use only one loop.
            // Print the result with 5 digits after the decimal point.
            Console.Write("n = ");
            uint n = uint.Parse(Console.ReadLine());
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            int nfact = 1;
            decimal sum = 1;

            for (int i = 1; i < n + 1; i++)
            {
                nfact *= i;
                sum = sum + nfact / (decimal)Math.Pow(x, i);
            }

            Console.WriteLine("{0:F5}", sum);
        }
    }
}