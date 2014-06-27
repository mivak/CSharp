namespace Task1NumbersFrom1ToN
{
    using System;

    public class Task1NumbersFrom1ToN
    {
        public static void Main()
        {
            // Write a program that enters from the console a positive integer n and prints all the numbers 
            // from 1 to n, on a single line, separated by a space.
            Console.Write("Please enter a positive integer number: ");
            uint number = uint.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (i == number)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}