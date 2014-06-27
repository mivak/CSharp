namespace Problem4NumberComparer
{
    using System;

    public class Problem4NumberComparer
    {
        public static void Main()
        {
            // Write a program that gets two numbers from the console and prints the greater of them.
            // Try to implement this without if statements.
            Console.Write("Please enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(firstNumber, secondNumber));
        }
    }
}