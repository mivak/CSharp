namespace Task05SortingNumbers
{
    using System;
    using System.Collections.Generic;
    
    public class Task5SortingNumbers
    {
        public static void Main()
        {
            // Write a program that reads a number n and a sequence of n integers, sorts them and prints them.
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            int count = n;
            List<int> sortedNumbers = new List<int>();
            while (count > 0)
            {
                int min = int.MaxValue;
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }
                }

                numbers.Remove(min);
                sortedNumbers.Add(min);
                count--;
            }

            Console.WriteLine();
            foreach (var number in sortedNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}