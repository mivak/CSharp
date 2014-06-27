namespace Task10CalculateGCD
{
    using System;
    
    public class Task10CalculateGCD
    {
        public static void Main()
        {
            // Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
            // Use the Euclidean algorithm (find it in Internet).
            Console.Write("first number = ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("second number = ");
            int secondNumber = int.Parse(Console.ReadLine());

            if (Math.Abs(firstNumber) < Math.Abs(secondNumber))
            {
                int temp = firstNumber;
                firstNumber = secondNumber;
                secondNumber = temp;
            }

            int remainder = firstNumber % secondNumber;
            while (remainder > 0)
            {
                firstNumber = secondNumber;
                secondNumber = remainder;
                remainder = firstNumber % secondNumber;
            }

            Console.WriteLine(secondNumber);
        }
    }
}