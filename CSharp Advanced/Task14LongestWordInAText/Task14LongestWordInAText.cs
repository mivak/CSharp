namespace Task14LongestWordInAText
{
    using System;
    
    public class Task14LongestWordInAText
    {
        public static void Main()
        {
            // Write a program to find the longest word in a text.
            Console.WriteLine("Please enter some text");
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ', '.', ',', '"', '!', '?', '-', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);

            int max = 0;
            string longestWord = string.Empty;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > max)
                {
                    max = words[i].Length;
                    longestWord = words[i];
                }
            }

            Console.WriteLine(longestWord);
        }
    }
}
