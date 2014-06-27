namespace Problem10FibonacciNumbers
{
    using System;
    using System.Numerics;

    public class Problem10FibonacciNumbers
    {
        public static void Main()
        {
            /*Write a program that reads a number n and prints on the console the first n members 
             * of the Fibonacci sequence (at a single line, separated by spaces) 
             * : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
             * Note that you may need to learn how to use loops.*/

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            BigInteger firstMember = 0;
            BigInteger secondMember = 1;
            if (n == 1)
            {
                Console.WriteLine(firstMember);
            }
            else if (n == 2)
            {
                Console.Write(firstMember + " " + secondMember);
            }
            else
            {
                Console.Write(firstMember + " " + secondMember);
                for (int i = 0; i < n - 2; i++)
                {
                    BigInteger nextMember = firstMember + secondMember;
                    Console.Write(" " + nextMember);
                    firstMember = secondMember;
                    secondMember = nextMember;
                }

                Console.WriteLine();
            }
        }
    }
}