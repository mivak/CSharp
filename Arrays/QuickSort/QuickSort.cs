// Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

namespace QuickSort
{
    using System;
    
    class QuickSort
    {
        static void Main()
        {
            Console.WriteLine("Please enter the length of the array: ");
            int length = int.Parse(Console.ReadLine());
            string[] words = new string[length];
            Console.WriteLine("Please enter the elements of the array:");

            for (int i = 0; i < length; i++)
            {
                words[i] = Console.ReadLine();
            }

            Sort(words, 0, length - 1);

            for (int i = 0; i < length; i++)
            {
                Console.Write(words[i] + " ");
            }
        }

        private static void Sort(string[] words, int left, int right)
        {
            int start = left;
            int end = right;
            string pivot = words[(left + right) / 2];

            while (start <= end)
            {
                while (words[start].CompareTo(pivot) < 0)
                {
                    start++;
                }

                while (words[end].CompareTo(pivot) > 0)
                {
                    end--;
                }

                if (start <= end)
                {
                    string currentElement = words[start];
                    words[start] = words[end];
                    words[end] = currentElement;

                    start++;
                    end--;
                }
            }

            if (left < end)
            {
                Sort(words, left, end);
            }

            if (start < right)
            {
                Sort(words, start, right);
            }
        }
    }
}