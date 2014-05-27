// Write a program that finds the maximal sequence of equal elements in an array.
// Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

namespace FindMaximalSequenceOfEqualElements
{
    using System;

    class FindMaximalSequenceOfEqualElements
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
            int equal = 0;

            for (int i = 0; i < n - 1; i++)
            {
                if (elements[i] == elements[i + 1])
                {
                    counter++;
                    if (counter > max)
                    {
                        max = counter;
                        equal = elements[i];
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            Console.WriteLine();

            for (int i = 0; i < max; i++)
            {
                Console.Write(equal + " ");
            }
        }
    }
}