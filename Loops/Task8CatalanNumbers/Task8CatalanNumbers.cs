namespace Task8CatalanNumbers
{
    using System;
    using System.Numerics;

    public class Task8CatalanNumbers
    {
        public static void Main()
        {
            // Write a program to calculate the nth Catalan number by given n (1 < n < 100).
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            BigInteger twoTimesNFact = 1;
            BigInteger factorialN = 1;

            for (int i = 1; i <= 2 * n; i++)
            {
                twoTimesNFact *= i;
                if (i == n)
                {
                    factorialN = twoTimesNFact;
                }
            }

            BigInteger catalan = twoTimesNFact / ((n + 1) * factorialN * factorialN);
            Console.WriteLine(catalan);
        }
    }
}