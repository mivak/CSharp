//Write a program to convert decimal numbers to their binary representation.

namespace DecimalToBinary
{
    using System;
    using System.Linq;

    class DecimalToBinary
    {
        private static string ReverseDigits(string numberAsString)
        {
            string reversed = null;
            for (int i = 0; i < numberAsString.Length; i++)
            {
                reversed += numberAsString[numberAsString.Length - 1 - i];
            }

            return reversed;
        }

        static void Main()
        {
            Console.Write("Please enter an integer number ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("The binary representation of this number is: 0");
            }
            else if (number > 0)
            {
                string binary = null;
                while (number > 0)
                {
                    binary += number % 2;
                    number = number / 2;
                }

                string binaryNumber = ReverseDigits(binary);
                Console.Write("The binary representation of this number is: {0}\n", binaryNumber);
            }
            else
            {
                string binary = null;
                number++;
                number = Math.Abs(number);
                while (number > 0)
                {
                    binary += Math.Abs(number % 2 - 1);
                    number = number / 2;
                }

                binary += 1;
                string binaryNumber = ReverseDigits(binary);
                Console.WriteLine("The binary representation of this number is: {0}\n", binaryNumber);
            }
        }
    }
}