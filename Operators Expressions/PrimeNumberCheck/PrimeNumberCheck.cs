namespace PrimeNumberCheck
{
    using System;

    public class PrimeNumberCheck
    {
        public static void Main()
        {
            // Write an expression that checks if given positive integer number n (n ≤ 100)
            // is prime (i.e. it is divisible without remainder only to itself and 1). 
            Console.WriteLine("Please enter a positive integer number n (n <= 100) ");
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;

            // By definition in wikipedia the number must be greater than 1
            if (number == 1)
            {
                isPrime = false;
            }

            if (number == 2)
            {
                isPrime = true;
            }
            else
            {
                // Little optimization from wikipedia
                for (int i = 2; i < Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }  
                }
            }

            Console.WriteLine("Is the number prime? {0}", isPrime);
        }
    }
}