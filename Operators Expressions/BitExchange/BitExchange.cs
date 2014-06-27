namespace BitExchange
{
    using System;
    
    public class BitExchange
    {
        public static void Main()
        {
            // Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
            Console.Write("Please enter a 32-bit unsigned integer: ");
            uint number = uint.Parse(Console.ReadLine());
            uint closeMask = 7; // I put 7 because I need to exchange 3 bits and the binary representation of 7 is 111
            uint farMask = 7;
            int closePosition = 3;
            int farPosition = 24;

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