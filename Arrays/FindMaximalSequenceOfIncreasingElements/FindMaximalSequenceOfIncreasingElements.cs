/* Write a program that finds the maximal increasing sequence in an array.
 * Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.*/

namespace FindMaximalSequenceOfIncreasingElements
{
    using System;

    class FindMaximalSequenceOfIncreasingElements
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            int[] elements = new int[n];

            for (int i = 0; i < n; i++)
            {
                elements[i] = int.Parse(Console.ReadLine());
            }

            int counter = 1;
            int max = 0;
            int position = 0;

            for (int i = 0; i < n - 1; i++)
            {
                if (elements[i] < elements[i + 1])
                {
                    counter++;
                    if (counter > max)
                    {
                        max = counter;
                        position = i + 2;
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            Console.WriteLine();
            for (int i = position - max; i < position; i++)
            {
                Console.Write(elements[i] + " ");
            }
        }
    }
}