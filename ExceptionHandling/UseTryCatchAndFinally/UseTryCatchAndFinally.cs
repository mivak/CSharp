// Write a program that reads an integer number and calculates and prints its square root. 
// If the number is invalid or negative, print "Invalid number". 
// In all cases finally print "Good bye". Use try-catch-finally.

namespace UseTryCatchAndFinally
{
    using System;

    class UseTryCatchAndFinally
    {
        static void Main()
        {
            Console.Write("Please enter a positive integer number: ");
            try
            {
                uint number = uint.Parse(Console.ReadLine());
                double squareRoot = Math.Sqrt(number);
                Console.WriteLine("The square root of {0} is {1}", number, squareRoot);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}