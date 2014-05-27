// Write a program that finds the index of given element in a sorted array of integers by using 
// the binary search algorithm (find it in Wikipedia).

namespace BinarySearch
{
    using System;
    class BinarySearch
    {
        static void Main()
        {
            Console.Write("The length of the array = ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Search for a number = ");
            int searchedNumber = int.Parse(Console.ReadLine());
            int[] array = new int[length];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Element[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);

            int min = 0;
            int max = length - 1;
            int middle = 0;

            while (min <= max)
            {
                middle = (max + min) / 2;
                if (array[middle] < searchedNumber)
                {
                    min = middle + 1;
                }
                else if (array[middle] > searchedNumber)
                {
                    max = middle - 1;
                }
                else
                {
                    break;
                }
            }

            if (array[middle] == searchedNumber)
            {
                Console.WriteLine("The searched number {0} was found at position {1}", searchedNumber, middle);
            }
            else
            {
                Console.WriteLine("The searched number {0} was not present in the array", searchedNumber);
            }
        }
    }
}