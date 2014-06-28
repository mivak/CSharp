namespace SortListOfWords
{
    using System;
    using System.Collections.Generic;

    public class SortListOfWords
    {
        public static void Main()
        {
            // Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
            string input = Console.ReadLine();
            string[] words = input.Split(' ', ',');
            List<string> sorted = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                sorted.Add(words[i]);
            }

            sorted.Sort();
            for (int i = 0; i < sorted.Count; i++)
            {
                Console.Write(sorted[i] + " ");
            }
        }
    }
}