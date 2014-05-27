//Write a program that finds the sequence of maximal sum in given array. Example:
//{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> {2, -1, 6, 4}
//Can you do it with only one loop (with single scan through the elements of the array)?

namespace FindMaximalSumInAnArray
{
    using System;
    class FindMaximalSumInAnArray
    {
        static void Main()
        {
            Console.Write("Please enter the length of array: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Please enter the length of sequence: ");
            int sequence = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Please enter element {0}: ", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            int maxSum = int.MinValue;
            int start = 0;
            int end = 0;

            for (int i = 0; i < length; i++)
            {
                sum += numbers[i];
                if (i >= sequence - 1)
                {
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        start = i - (sequence - 1);
                        end = start + sequence;
                    }

                    sum -= numbers[i - (sequence - 1)];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Maximal sum is: {0}", maxSum);
            Console.WriteLine("Sequence with maximal sum is: ");
            Console.Write('{');

            for (int i = start; i < end; i++)
            {
                Console.Write(numbers[i]);
                if (i < end - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.Write("}");
            Console.WriteLine();
        }
    }
}