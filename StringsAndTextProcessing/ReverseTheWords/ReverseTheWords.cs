namespace ReverseTheWords
{
    using System;

    public class ReverseTheWords
    {
        public static void Main()
        {
            string input = "C# is not C++, not PHP and not Delphi!";
            string text = input.Substring(0, input.Length - 1);
            string lastChar = input.Substring(input.Length - 1, 1);
            string[] words = text.Split(' ');
            string[] reverse = new string[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                reverse[i] = words[words.Length - 1 - i];
                if (i == words.Length - 1)
                {
                    Console.Write(reverse[i] + lastChar);
                }
                else
                {
                    Console.Write(reverse[i] + " ");
                }
            }

            Console.WriteLine();
        }
    }
}