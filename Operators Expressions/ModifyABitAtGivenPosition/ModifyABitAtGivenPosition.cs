﻿namespace ModifyABitAtGivenPosition
{
    using System;

    public class ModifyABitAtGivenPosition
    {
        public static void Main()
        {
            /*We are given an integer number n, a bit value v (v=0 or 1) and a position p.
             * Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v
             * at the position p from the binary representation of n while preserving all other bits in n.*/

            Console.Write("number = ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("bitValue = ");
            int bitValue = int.Parse(Console.ReadLine());
            Console.Write("position = ");
            int position = int.Parse(Console.ReadLine());

            int mask = 1 << position;
            mask = ~mask;
            int result = number & mask;
            mask = bitValue << position;
            result = result | mask;
            Console.WriteLine(result);
        }
    }
}