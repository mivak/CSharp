namespace Task11TrailingZeros
{
    using System;

    public class Task11TrailingZeros
    {
        public static void Main()
        {
            // Write a program that calculates with how many zeroes the factorial of a given number n
            // has at its end. Your program should work well for very big numbers, e.g. n=100000.
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            long trailingZeros = n / 5;
            int pow = 1;

            while (n >= Math.Pow(5, pow))
            {
                pow++;
                trailingZeros += n / (long)Math.Pow(5, pow);
            }

            Console.WriteLine("Trailing zeros: {0}", trailingZeros);
        }
    }
}