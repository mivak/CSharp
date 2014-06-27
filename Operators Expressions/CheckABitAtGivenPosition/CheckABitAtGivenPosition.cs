namespace CheckABitAtGivenPosition
{
    using System;

    public class CheckABitAtGivenPosition
    {
        public static void Main()
        {
            // Write a Boolean expression that returns if the bit at position p
            // (counting from 0, starting from the right) in given integer number n has value of 1. 
            Console.Write("Please enter an integer: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter the value of the index: ");
            int p = int.Parse(Console.ReadLine());

            bool isOne;
            int mask = 1 << p;
            int result = mask & n;

            result = result >> p;
            if (result == 1)
            {
                isOne = true;
            }
            else
            {
                isOne = false;
            }

            Console.WriteLine("Is the bit 1? {0}", isOne);
        }
    }
}