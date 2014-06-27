namespace Task3PrimesInGivenRange
{
    using System;
    using System.Collections.Generic;

    public class Task3PrimesInGivenRange
    {
        public static void Main()
        {
            /*Write a method that calculates all prime numbers in given range and returns them as list of integers:
             * static List<int> FindPrimesInRange(startNum, endNum)
                {
                    …
                }
             Write a method to print a list of integers. Write a program that enters two integer numbers 
             * (each at a separate line) and prints all primes in their range, separated by a comma.*/

            Console.WriteLine("Please enter the range");
            Console.Write("start = ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("end = ");
            int end = int.Parse(Console.ReadLine());
            List<int> primes = FindPrimesInRange(start, end);

            for (int i = 0; i < primes.Count; i++)
            {
                if (i != primes.Count - 1)
                {
                    Console.Write(primes[i] + ", ");
                }
                else
                {
                    Console.Write(primes[i]);
                }
            }

            Console.WriteLine();
        }

        public static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primes = new List<int>();
            if (startNum < 2)
            {
                startNum = 2;
            }

            for (int i = startNum; i <= endNum; i++)
            {
                bool isPrime = IsPrime(i);
                if (isPrime == true)
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        public static bool IsPrime(int n)
        {
            bool isPrime = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
    }
}