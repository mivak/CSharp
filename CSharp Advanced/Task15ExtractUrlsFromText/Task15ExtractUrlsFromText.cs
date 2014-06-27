namespace Task15ExtractUrlsFromText
{
    using System;

    public class Task15ExtractUrlsFromText
    {
        public static void Main()
        {
            /*Write a program that extracts and prints all URLs from given text. URL can be in only two formats:
            •   http://something, e.g. http://softuni.bg, http://forums.softuni.bg, http://www.nakov.com 
            •   www.something.domain, e.g. www.nakov.com, www.softuni.bg, www.google.com
            */

            Console.WriteLine("Please enter some text");
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ', ',', '?', '"', '!', ';' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].TrimEnd('.');
                if (words[i].Length > 7)
                {
                    if (words[i].Substring(0, 7) == "http://")
                    {
                        Console.WriteLine(words[i]);
                    }
                    else if (words[i].Substring(0, 4) == "www.")
                    {
                        Console.WriteLine(words[i]);
                    }
                }
            }
        }
    }
}