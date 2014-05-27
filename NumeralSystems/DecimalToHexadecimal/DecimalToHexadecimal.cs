// Write a program to convert decimal numbers to their hexadecimal representation.

namespace DecimalToHexadecimal
{
    using System;
    using System.Linq;
    class DecimalToHexadecimal
    {
        static void Main()
        {
            Console.Write("Please enter a decimal number ");
            int number = int.Parse(Console.ReadLine());
            string hexadecimal = null;

            while (number > 0)
            {
                int remainder = number % 16;
                switch (remainder)
                {
                    case 10: hexadecimal += 'A'; break;
                    case 11: hexadecimal += 'B'; break;
                    case 12: hexadecimal += 'C'; break;
                    case 13: hexadecimal += 'D'; break;
                    case 14: hexadecimal += 'E'; break;
                    case 15: hexadecimal += 'F'; break;
                    default: hexadecimal += remainder;
                        break;
                }

                number = number / 16;
            }

            string reversed = Reverse(hexadecimal);
            Console.WriteLine("The hexadecimal representation of this number is: {0}", reversed);
        }

        private static string Reverse(string number)
        {
            string reversed = null;
            for (int i = 0; i < number.Length; i++)
            {
                reversed += number[number.Length - 1 - i];
            }

            return reversed;
        }
    }
}