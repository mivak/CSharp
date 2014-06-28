namespace ForbiddenWords
{
    using System;

    public class ForbiddenWords
    {
        public static void Main()
        {
            // We are given a string containing a list of forbidden words and a text containing some of these words. 
            // Write a program that replaces the forbidden words with asterisks. Example:
            // Microsoft announced its next generation PHP compiler today. It is based on .NET 
            // Framework 4.0 and is implemented as a dynamic language in CLR.
            // Words: "PHP, CLR, Microsoft"
            // The expected result:
            // ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 
            // and is implemented as a dynamic language in ***.
            string givenText = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string words = "PHP, CLR, Microsoft";
            string[] newWords = words.Split(',');

            for (int i = 0; i < newWords.Length; i++)
            {
                newWords[i] = newWords[i].Trim();
            }

            for (int i = 0; i < newWords.Length; i++)
            {
                givenText = givenText.Replace(newWords[i], new string('*', newWords[i].Length));
            }

            Console.WriteLine(givenText);
        }
    }
}