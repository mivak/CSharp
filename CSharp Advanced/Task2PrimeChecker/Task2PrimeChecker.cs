namespace Task2PrimeChecker
{
    using System;
    
    public class Task2PrimeChecker
    {
        public static void Main()
        {
            // Write a Boolean method IsPrime(n) that check whether a given integer number n is prime.
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
        }

        public static bool IsPrime(int n)
        {
            bool isPrime = true;
            if (n > 1)
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            else
            {
                isPrime = false;
            }
            

            return isPrime;
        }
    }
}