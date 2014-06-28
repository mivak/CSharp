namespace ReverseString
{
    using System;

    public class Program
    {
        public static void Main()
        {
            // Write a program that reads a string, reverses it and prints the result at the console.
            // Example: "sample"  "elpmas".
            Console.Write("Please enter a string: ");
            string sample = Console.ReadLine();
            string reversed = null;

            for (int i = 0; i < sample.Length; i++)
            {
                reversed += sample[sample.Length - i - 1];
            }

            Console.WriteLine(reversed);
        }
    }
}