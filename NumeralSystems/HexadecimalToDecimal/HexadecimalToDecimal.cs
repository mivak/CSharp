// Write a program to convert hexadecimal numbers to their decimal representation.

namespace HexadecimalToDecimal
{
    using System;
    using System.Linq;

    class HexadecimalToDecimal
    {
        static void Main()
        {
            Console.Write("Please enter a hexadecimal number without 0x: ");
            string hexa = Console.ReadLine();
            int number = 0;

            for (int i = 0; i < hexa.Length; i++)
            {
                switch (hexa[i])
                {
                    case 'A': number += 10 * (int)Math.Pow(16, hexa.Length - 1 - i); break;
                    case 'B': number += 11 * (int)Math.Pow(16, hexa.Length - 1 - i); break;
                    case 'C': number += 12 * (int)Math.Pow(16, hexa.Length - 1 - i); break;
                    case 'D': number += 13 * (int)Math.Pow(16, hexa.Length - 1 - i); break;
                    case 'E': number += 14 * (int)Math.Pow(16, hexa.Length - 1 - i); break;
                    case 'F': number += 15 * (int)Math.Pow(16, hexa.Length - 1 - i); break;
                    default: number += (hexa[i] - 48) * (int)Math.Pow(16, hexa.Length - 1 - i);
                        break;
                }
            }

            Console.WriteLine("The decimal representation of this number is: {0}", number);
        }
    }
}