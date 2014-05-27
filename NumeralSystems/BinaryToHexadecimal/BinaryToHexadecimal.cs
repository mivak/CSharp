//Write a program to convert binary numbers to hexadecimal numbers (directly).

namespace BinaryToHexadecimal
{
    using System;
    using System.Linq;

    class BinaryToHexadecimal
    {
        private static string BinaryNumberToHexadecimal(string binary)
        {
            string hexadecimal = string.Empty;
            string digits = string.Empty;

            for (int i = 0; i < binary.Length; i+=4)
            {
                digits = binary.Substring(i, 4);
                switch (digits)
                {
                    case "0001": hexadecimal += '1'; break;
                    case "0010": hexadecimal += '2'; break;
                    case "0011": hexadecimal += '3'; break;
                    case "0100": hexadecimal += '4'; break;
                    case "0101": hexadecimal += '5'; break;
                    case "0110": hexadecimal += '6'; break;
                    case "0111": hexadecimal += '7'; break;
                    case "1000": hexadecimal += '8'; break;
                    case "1001": hexadecimal += '9'; break;
                    case "1010": hexadecimal += 'A'; break;
                    case "1011": hexadecimal += 'B'; break;
                    case "1100": hexadecimal += 'C'; break;
                    case "1101": hexadecimal += 'D'; break;
                    case "1110": hexadecimal += 'E'; break;
                    case "1111": hexadecimal += 'F'; break;
                }
            }

            return hexadecimal;
        }

        static void Main()
        {
            Console.Write("Please enter a binary number: ");
            string binary = Console.ReadLine();
            string hexadecimal = BinaryNumberToHexadecimal(binary);
            Console.WriteLine("The hexadecimal representation of this number is: {0}", hexadecimal);
        }
    }
}