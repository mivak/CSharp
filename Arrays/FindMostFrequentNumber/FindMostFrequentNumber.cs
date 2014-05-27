// Write a program that finds the most frequent number in an array. Example:
// {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

namespace FindMostFrequentNumber
{
    using System;

    class FindMostFrequentNumber
    {
        static void Main()
        {
            
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Element[{0}] = ", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int frequency = 0;
            int maxFrequency = 0;
            int value = 0;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        frequency++;
                    }

                    if (frequency > maxFrequency)
                    {
                        maxFrequency = frequency;
                        value = numbers[i];
                    }
                }

                frequency = 0;
            }

            Console.WriteLine();
            Console.WriteLine("{0} ({1} times)", value, maxFrequency);
        }
    }
}