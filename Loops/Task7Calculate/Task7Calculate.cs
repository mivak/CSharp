namespace Task7Calculate
{
    using System;
    using System.Numerics;

    public class Task7Calculate
    {
        public static void Main()
        {
            /*In combinatorics, the number of ways to choose k different members out of a group 
             * of n different elements (also known as the number of combinations) is calculated by 
             * the following formula:*/

            Console.WriteLine("Please enter n & k (1 < k < n < 100)");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            BigInteger factorialN = 1;
            BigInteger factorialK = 1;

            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
                if (i == k)
                {
                    factorialK = factorialN;
                }
            }

            BigInteger nk = 1;
            for (int i = 1; i <= n - k; i++)
            {
                nk *= i;
            }

            Console.WriteLine(factorialN / (factorialK * nk));
        }
    }
}