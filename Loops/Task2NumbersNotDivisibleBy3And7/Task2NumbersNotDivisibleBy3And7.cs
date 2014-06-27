﻿namespace Task2NumbersNotDivisibleBy3And7
{
    using System;

    public class Task2NumbersNotDivisibleBy3And7
    {
        public static void Main()
        {
            // Write a program that enters from the console a positive integer n and prints all the numbers
            // from 1 to n not divisible by 3 and 7, on a single line, separated by a space.
            Console.Write("Please enter a positive integer number: ");
            uint number = uint.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 != 0 || i % 7 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}