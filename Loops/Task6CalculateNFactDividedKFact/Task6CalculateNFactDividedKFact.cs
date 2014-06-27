namespace Task6CalculateNFactDividedKFact
{
    using System;

    public class Task6CalculateNFactDividedKFact
    {
        public static void Main()
        {
            // Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
            // Use only one loop.
            Console.WriteLine("Please enter n & k (1 < k < n < 100)");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            int factorialN = 1;
            int factorialK = 1;

            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
                if (i == k)
                {
                    factorialK = factorialN;
                }
            }

            Console.WriteLine(factorialN / factorialK);
        }
    }
}