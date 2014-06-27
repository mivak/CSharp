namespace FourDigitNumber
{
    using System;

    public class FourDigitNumber
    {
        public static void Main()
        {
                /*Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
                •   Calculates the sum of the digits (in our example 2+0+1+1 = 4).
                •   Prints on the console the number in reversed order: dcba (in our example 1102).
                •   Puts the last digit in the first position: dabc (in our example 1201).
                •   Exchanges the second and the third digits: acbd (in our example 2101).
                The number has always exactly 4 digits and cannot start with 0.*/

            Console.Write("Please enter a four-digit number: ");
            string numberAsString = Console.ReadLine();
            int initialNumber = int.Parse(numberAsString);
            int number = initialNumber;
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            number = initialNumber;

            int reversed = 0;
            int pow = numberAsString.Length - 1;

            while (number > 0)
            {
                reversed += (number % 10) * (int)Math.Pow(10, pow);
                number /= 10;
                pow--;
            }

            number = initialNumber;
            pow = numberAsString.Length - 1;

            int changed = (number % 10) * (int)Math.Pow(10, pow) + number / 10;
            int exchanged = number / 1000;
            exchanged *= 1000;
            number /= 10;
            exchanged += (number % 10) * 100;
            number /= 10;
            exchanged += (number % 10) * 10;
            number = initialNumber;
            exchanged += number % 10;

            Console.WriteLine("sum: {0}\nreversed: {1}\nchanged: {2}\nexchanged: {3}", sum, reversed, changed, exchanged);
        }
    }
}