namespace OddOrEven
{
    using System;

    public class OddOrEven
    {
        public static void Main()
        {
            // Write an expression that checks if given integer is odd or even.
            bool isOdd;
            Console.Write("Please enter an integer number: ");
            int number = int.Parse(Console.ReadLine());

            // if you make it number % 2 == 1 it will not be true for a negative odd number!!!
            if (number % 2 != 0)
            {
                isOdd = true;
            }
            else
            {
                isOdd = false;
            }

            Console.WriteLine("Is the number {0} odd? {1}", number, isOdd);
        }
    }
}