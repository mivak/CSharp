namespace ThirdDigitIs7
{
    using System;

    public class ThirdDigitIs7
    {
        public static void Main()
        {
            // Write an expression that checks for given integer if its third digit from right-to-left is 7.
            bool isThirdDigit7;
            Console.Write("Please enter an integer number: ");
            int number = int.Parse(Console.ReadLine());

            if ((number / 100) % 10 == 7)
            {
                isThirdDigit7 = true;
            }
            else
            {
                isThirdDigit7 = false;
            }

            Console.WriteLine("Is the third digit 7: {0}", isThirdDigit7);
        }
    }
}