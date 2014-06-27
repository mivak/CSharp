namespace Problem1SumOfIntegers
{
    using System;

    public class Problem1SumOfIntegers
    {
        public static void Main()
        {
            // Write a program that reads 3 integer numbers from the console and prints their sum.
            Console.Write("Please enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Please enter the third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber + thirdNumber;
            Console.WriteLine("The sum of the numbers is: {0}", sum);
        }
    }
}