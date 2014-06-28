namespace ReplaceConsecutiveLetters
{
    using System;
    using System.Text;

    public class ReplaceConsecutiveLetters
    {
        public static void Main()
        {
            // Write a program that reads a string from the console and replaces all series of consecutive
            // identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".
            string input = Console.ReadLine();
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0)
                {
                    builder.Append(input[i]);
                }
                else if (input[i] != input[i - 1])
                {
                    builder.Append(input[i]);
                }
            }

            Console.WriteLine(builder.ToString());
        }
    }
}