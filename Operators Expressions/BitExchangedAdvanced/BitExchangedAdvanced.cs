namespace BitExchangedAdvanced
{
    using System;
    
    public class BitExchangedAdvanced
    {
        public static void Main()
        {
            // Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given
            // 32-bit unsigned integer. The first and the second sequence of bits may not overlap.
            Console.Write("Please enter a 32-bit unsigned integer: ");
            uint number = uint.Parse(Console.ReadLine());
            Console.Write("p = ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("q = ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            uint closeMask = (uint)Math.Pow(2, k) - 1;
            uint farMask = (uint)Math.Pow(2, k) - 1;
            int closePosition = p;
            int farPosition = q;

            if (Math.Abs(p - q) < k)
            {
                Console.WriteLine("overlapping");
            }
            else if (p + k > 32 || q + k > 32 || p < 0 || q < 0)
            {
                Console.WriteLine("out of range");
            }
            else
            {
                closeMask = closeMask << closePosition;
                uint closeBitsValues = number & closeMask;
                closeBitsValues = closeBitsValues >> closePosition; // Now I have the close bits

                farMask = farMask << farPosition;
                uint farBitsValues = number & farMask;
                farBitsValues = farBitsValues >> farPosition; // Now I have the far bits too

                uint invertedCloseMask = ~closeMask;
                number = number & invertedCloseMask; // I set the close bits to zero

                uint invertedFarMask = ~farMask;
                number = number & invertedFarMask; // I set the far bits to zero

                closeBitsValues = closeBitsValues << farPosition;
                number = number | closeBitsValues;

                farBitsValues = farBitsValues << closePosition;
                number = number | farBitsValues;

                Console.WriteLine(number);
            }
        }
    }
}