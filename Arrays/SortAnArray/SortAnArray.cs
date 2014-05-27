/* Sorting an array means to arrange its elements in increasing order.
 * Write a program to sort an array. Use the "selection sort" algorithm:
 * Find the smallest element, move it at the first position, find the smallest from the rest,
 * move it at the second position, etc.*/

namespace SortAnArray
{
    using System;
    class SortAnArray
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int min = int.MaxValue;
            int position = 0;

            for (int i = 0; i < length; i++)
            {
                for (int j = i; j < length; j++)
                {
                    if (numbers[j] < min)
                    {
                        min = numbers[j];
                        position = j;
                    }
                }

                numbers[position] = numbers[i];
                numbers[i] = min;
                min = int.MaxValue;
            }

            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}