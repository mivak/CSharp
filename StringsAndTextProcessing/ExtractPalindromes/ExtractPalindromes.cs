namespace ExtractPalindromes
{
    using System;

    public class ExtractPalindromes
    {
        public static void Main()
        {
            // Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
            string text = "jdsksd dsfkddsf sdfkddsf ds abba lamal dk dkd exe addda .,,.";
            string[] words = text.Split(' ');
            string palindrome = null;

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length / 2; j++)
                {
                    palindrome = words[i];
                    if (words[i][j] != words[i][words[i].Length - 1 - j])
                    {
                        palindrome = null;
                    }
                }

                if (palindrome != null)
                {
                    Console.WriteLine(palindrome);
                }

                palindrome = null;
            }
        }
    }
}