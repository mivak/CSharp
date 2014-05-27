// Write a program that shows the binary representation of given 16-bit signed integer number 
// (the C# type short).

namespace BinaryRepresentationOf16bitSignedInteger
{
    using System;
    using System.Linq;

    class BinaryRepresentationOf16bitSignedInteger
    {
        private static string ReverseDigits(string numString)
        {
            string reversed = null;
            for (int i = 0; i < numString.Length; i++)
            {
                reversed += numString[numString.Length - 1 - i];
            }

            return reversed;
        }

        static void Main()
        {
            Console.Write("Please enter a signed short number: ");
            short number = short.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("The binary representation of this number is: {0}", new string('0', 16));
            }
            else if (number > 0)
            {
                string binary = null;
                while (number > 0)
                {
                    binary += number % 2;
                    number = (short)(number / 2);
                }

                string binaryNumber = ReverseDigits(binary);
                string bin = new string('0', 16 - binaryNumber.Length);
                string result = bin + binaryNumber;
                Console.WriteLine("The binary representation of this number is: {0}", result);
            }
            else
            {
                string binary = null;
                number++;
                number = Math.Abs(number);
                while (number > 0)
                {
                    binary += Math.Abs(number % 2 - 1);
                    number = (short)(number / 2);
                }

                binary += 1;
                string binaryNumber = ReverseDigits(binary);
                string result = new string('1', 16 - binaryNumber.Length) + binaryNumber;
                Console.WriteLine("The binary representation of this number is: {0}", result);
            }
        }
    }
}