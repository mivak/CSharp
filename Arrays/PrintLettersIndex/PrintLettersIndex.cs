// Write a program that creates an array containing all letters from the alphabet (A-Z).
// Read a word from the console and print the index of each of its letters in the array.

namespace PrintLettersIndex
{
    using System;

    class PrintLettersIndex
    {
        static void Main()
        {
            const int AlphabetLength = 26;
            char[] letters = new char[AlphabetLength];

            for (int i = 0; i < AlphabetLength; i++)
            {
                letters[i] = (char)(65 + i);
            }

            Console.Write("Please enter a word ");
            string word = Console.ReadLine().ToUpper();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < AlphabetLength; j++)
                {
                    if (word[i] == letters[j])
                    {
                        Console.Write(j + " ");
                        break;
                    }
                }
            }
        }
    }
}