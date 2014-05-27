// Write a program to convert binary numbers to their decimal representation.

namespace BinaryToDecimal
{
    using System;

    class BinaryToDecimal
    {
        static string ReverseDigits(string numString)
        {
            string reversed = string.Empty;
            for (int i = 0; i < numString.Length; i++)
            {
                reversed += numString[numString.Length - 1 - i];
            }

            return reversed;
        }

        static void Main()
        {
            Console.Write("Please enter a binary number ");
            string binary = Console.ReadLine();
            int number = 0;
            string reversed = ReverseDigits(binary);
            int binNumber = int.Parse(reversed);

            for (int i = 0; i < binary.Length; i++)
            {
                number += (int)((binNumber % 10) * Math.Pow(2, binary.Length - i - 1));
                binNumber /= 10;
            }

            Console.WriteLine("The decimal representation of this number is: {0}", number);
        }
    }
}