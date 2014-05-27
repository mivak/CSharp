// Write a program that finds all prime numbers in the range [1...10 000 000].
// Use the "Sieve of Eratosthenes" algorithm (find it in Wikipedia).

namespace FindAllPrimeNumbersInRange
{
    using System;

    class FindAllPrimeNumbersInRange
    {
        static void Main()
        {
            bool[] primeNumbers = new bool[10000001];
            for (int i = 0; i < primeNumbers.Length; i++)
            {
                primeNumbers[i] = true;
            }

            for (int i = 2; i <= Math.Sqrt(primeNumbers.Length); i++)
            {
                if (primeNumbers[i])
                {
                    for (int j = i * i; j < primeNumbers.Length; j += i)
                    {
                        primeNumbers[j] = false;
                    }
                }
            }

            for (int i = 2; i < primeNumbers.Length; i++)
            {
                if (primeNumbers[i])
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}