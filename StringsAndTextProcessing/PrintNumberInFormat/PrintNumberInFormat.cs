namespace PrintNumberInFormat
{
    using System;

    public class PrintNumberInFormat
    {
        public static void Main()
        {
            // Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
            // percentage and in scientific notation. Format the output aligned right in 15 symbols.
            Console.Write("Please enter a number: ");
            string num = Console.ReadLine();
            int number = int.Parse(num);

            Console.WriteLine("The number as decimal: {0:D15}", number);
            Console.WriteLine("The number as hexadecimal number: {0:X15}", number);
            Console.WriteLine("The number as percentage: {0:P15}", number);
            Console.WriteLine("The number as exponential notation: {0:E15}", number);
        }
    }
}