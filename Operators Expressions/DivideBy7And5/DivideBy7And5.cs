namespace DivideBy7And5
{
    using System;

    public class DivideBy7And5
    {
        public static void Main()
        {
            // Write a Boolean expression that checks for given integer
            // if it can be divided (without remainder) by 7 and 5 in the same time.
            Console.Write("Please enter an integer number: ");
            int number = int.Parse(Console.ReadLine());
            bool isDivided;

            if (number % 5 == 0 && number % 7 == 0)
            {
                isDivided = true;
            }
            else
            {
                isDivided = false;
            }

            Console.WriteLine("Can the number {0} be divided by 7 and 5 in the same time? {1}", number, isDivided);
        }
    }
}