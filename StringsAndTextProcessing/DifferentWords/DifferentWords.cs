namespace DifferentWords
{
    using System;
    using System.Collections.Generic;

    public class DifferentWords
    {
        public static void Main()
        {
            // Write a program that reads a string from the console and lists all different words in the string
            // along with information how many times each word is found.
            string input = Console.ReadLine();
            input = input.Trim();
            string[] words = input.Split(' ', ',', '(', ')', '[', ']', '.', ':', ';', '!', '?', '/', '\\', '|');
            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (dict.ContainsKey(words[i]))
                {
                    dict[words[i]]++;
                }
                else if (words[i] != string.Empty)
                {
                    dict.Add(words[i], 1);
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine("{0} {1}", item.Key, item.Value);
            }
        }
    }
}