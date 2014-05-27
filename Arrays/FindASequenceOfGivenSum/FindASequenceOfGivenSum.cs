/*Write a program that finds in given array of integers a sequence of given sum S (if present).
Example:{4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}*/

namespace FindASequenceOfGivenSum
{
    using System;

    class FindASequenceOfGivenSum
    {
        static void Main()
        {
            int k = 0;
            int numOfSums = 0;
            int sum = 0;
            int start = 0;
            int end = 0;

            Console.Write("Please enter the length of the array: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter the searched sum: ");
            int s = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Please enter the {0} index ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The searched elements are: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j < n)
                    {
                        sum += array[i + j];
                        if (sum == s)
                        {
                            start = i;
                            end = i + j;
                            numOfSums++;

                            for (k = start; k <= end; k++)
                            {
                                Console.Write("{0}; ", array[k]);
                            }

                            Console.WriteLine();
                        }
                    }
                }

                sum = 0;
            }
        }
    }
}