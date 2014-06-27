namespace Task9MatrixOfNumbers
{
    using System;

    public class Task9MatrixOfNumbers
    {
        public static void Main()
        {
            // Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and
            // prints a matrix like in the examples below. Use two nested loops.
            Console.WriteLine("Please enter n (1 <= n <= 20)");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j <= n + i; j++)
                {
                    if (j == n + i)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write(j + " ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}