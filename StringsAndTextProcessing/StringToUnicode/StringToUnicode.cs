namespace StringToUnicode
{
    using System;
    using System.Text;

    public class StringToUnicode
    {
        public static void Main()
        {
            // Write a program that converts a string to a sequence of C# Unicode character literals.
            // Use format strings. Sample input:
            // Hi!
            // Expected output:
            // \u0048\u0069\u0021
            string word = "Hi!";
            char[] letters = word.ToCharArray();
            StringBuilder builder = new StringBuilder();

            foreach (var letter in letters)
            {
                string append = ((short)letter).ToString("X");
                string toAppend = "\\u";
                string zero = new string('0', 4 - append.Length);
                builder.Append(toAppend + zero + append);
            }

            Console.WriteLine(builder.ToString());
        }
    }
}