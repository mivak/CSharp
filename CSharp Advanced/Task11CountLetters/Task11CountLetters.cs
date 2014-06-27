namespace Task11CountLetters
{
    using System;
    using System.Collections.Generic;

    public class Task11CountLetters
    {
        public static void Main()
        {
            // Write a program that reads a list of letters and prints for each letter
            // how many times it appears in the list. The letters should be listed in 
            // alphabetical order. Use the input and output format from the examples below.
            Console.WriteLine("Please enter a sequence of letters separated by space");
            string text = Console.ReadLine();
            int counter = 1;

            List<char> letters = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    letters.Add(text[i]);
                }
            }

            letters.Sort();

            for (int i = 0; i < letters.Count - 1; i++)
            {
                if (i == letters.Count - 2)
                {
                    if (letters[i] == letters[i + 1])
                    {
                        counter++;
                        Console.WriteLine(letters[i] + " -> " + counter);
                    }
                    else
                    {
                        if (letters[i] == letters[i - 1])
                        {
                            Console.WriteLine(letters[i] + " -> " + counter);
                            counter = 1;
                        }

                        Console.WriteLine(letters[i + 1] + " -> " + counter);
                        counter = 1;
                    }
                }
                else
                {
                    if (letters[i] == letters[i + 1])
                    {
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine(letters[i] + " -> " + counter);
                        counter = 1;
                    }
                }
            }
        }
    }
}