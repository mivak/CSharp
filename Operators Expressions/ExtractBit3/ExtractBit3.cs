namespace ExtractBit3
{
    using System;

    public class ExtractBit3
    {
        public static void Main()
        {
            // Using bitwise operators, write an expression for finding the value of the bit #3 of a 
            // given unsigned integer. The bits are counted from
            // right to left, starting from bit #0. The result of the expression should be either 1 or 0.
            int position = 3;
            int number = int.Parse(Console.ReadLine());
            int mask = 1;
            mask = mask << position;
            int result = number & mask;
            result = result >> position;
            Console.WriteLine(result);
        }
    }
}