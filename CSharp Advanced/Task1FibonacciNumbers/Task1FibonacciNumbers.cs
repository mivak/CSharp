namespace Task1FibonacciNumbers
{
    using System;

    public class Task1FibonacciNumbers
    {
        public static void Main()
        {
            // Define a method Fib(n) that calculates the nth Fibonacci number.
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));
        }

        public static int Fib(int n)
        {
            int firstMember = 1;
            int secondMember = 1;
            int nextMember = firstMember + secondMember;

            for (int i = 0; i < n - 2; i++)
            {
                firstMember = secondMember;
                secondMember = nextMember;
                nextMember = firstMember + secondMember;
            }

            return nextMember;
        }
    }
}