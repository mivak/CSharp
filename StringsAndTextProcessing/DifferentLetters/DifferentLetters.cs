namespace DifferentLetters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class DifferentLetters
    {
        public static void Main()
        {
            // Write a program that reads a string from the console and prints all different letters in the 
            // string along with information how many times each letter is found. 
            string inputText = Console.ReadLine();
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < inputText.Length; i++)
            {
                if (char.IsLetter(inputText[i]))
                {
                    builder.Append(inputText[i]);
                }
            }

            Dictionary<char, int> dict = new Dictionary<char, int>();
            string allLetters = builder.ToString();
            for (int i = 0; i < allLetters.Length; i++)
            {
                if (dict.ContainsKey(allLetters[i]))
                {
                    dict[allLetters[i]]++;
                }
                else
                {
                    dict.Add(allLetters[i], 1);
                }
            }

            var sorted = dict.OrderBy(x => x.Value);
            foreach (var item in sorted)
            {
                Console.WriteLine("{0} {1}", item.Key, item.Value);
            }
        }
    }
}