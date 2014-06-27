namespace ExtractBitFromInteger
{
    using System;
    
    public class ExtractBitFromInteger
    {
        public static void Main()
        {
            // Write an expression that extracts from given integer n the value of given bit at index p.
            Console.Write("Please enter an integer: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter the value of the index: ");
            int p = int.Parse(Console.ReadLine());

            int mask = 1 << p;
            int result = mask & n;
            result = result >> p;
            Console.WriteLine(result);
        }
    }
}