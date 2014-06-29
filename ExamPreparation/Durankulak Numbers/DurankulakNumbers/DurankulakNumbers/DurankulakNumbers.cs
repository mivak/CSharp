namespace DurankulakNumbers
{
    using System;
    using System.Collections.Generic;

    public class DurankulakNumbers
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<int> digits = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    digits.Add(input[i] - 'A');
                }
                else
                {
                    digits.Add((input[i] - 'a' + 1) * 26 + input[i + 1] - 'A');
                    i++;
                }
            }

            long number = 0;
            for (int i = 0; i < digits.Count; i++)
            {
                number += (long)digits[i] * (long)Math.Pow(168, digits.Count - 1 - i);
            }

            Console.WriteLine(number);
        }
    }
}