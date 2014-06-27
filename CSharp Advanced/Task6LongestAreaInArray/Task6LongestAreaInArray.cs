namespace Task6LongestAreaInArray
{
    using System;

    public class Task6LongestAreaInArray
    {
        public static void Main()
        {
            /*Write a program to find the longest area of equal elements in array of strings. 
             * You first should read an integer n and n strings (each at a separate line), then 
             * find and print the longest sequence of equal elements (first its length, then its elements). 
             * If multiple sequences have the same maximal length, print the leftmost of them.*/

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            string[] elements = new string[n];

            for (int i = 0; i < n; i++)
            {
                elements[i] = Console.ReadLine();
            }

            int counter = 1;
            int max = 0;
            string equal = string.Empty;

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
            Console.WriteLine(max);
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine(equal);
            }
        }
    }
}