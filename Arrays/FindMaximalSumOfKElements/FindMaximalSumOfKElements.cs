// Write a program that reads two integer numbers N and K and an array of N elements from the console.
// Find in the array those K elements that have maximal sum.

namespace FindMaximalSumOfKElements
{
    using System;
    class FindMaximalSumOfKElements
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] elements = new int[n];

            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = int.Parse(Console.ReadLine());
            }

            string sequence = string.Empty;
            int sum = 0;
            int maxSum = int.MinValue;
            string currentSequence = string.Empty;

            for (int i = 0; i < n; i++)
            {
                
                if (i + k > n)
                {
                    break;
                }

                for (int j = i; j < i + k; j++)
                {
                    sum += elements[j];
                    currentSequence += elements[j] + " ";
                }

                if (sum > maxSum)
                {
                    sequence = currentSequence;
                    maxSum = sum;
                }

                sum = 0;
                currentSequence = string.Empty;
            }

            Console.WriteLine(sequence);
            Console.WriteLine(maxSum);
        }
    }
}