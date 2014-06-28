namespace Problem5TheBiggestOfThreeNumbers
{
    using System;
    
    public class Problem5TheBiggestOfThreeNumbers
    {
        public static void Main()
        {
            // Write a program that finds the biggest of three numbers.
            Console.Write("first number = ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("second number = ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("third number = ");
            int thirdNumber = int.Parse(Console.ReadLine());

            int biggestNumber = Math.Max(firstNumber, secondNumber);
            biggestNumber = Math.Max(biggestNumber, thirdNumber);
            Console.WriteLine(biggestNumber);
        }
    }
}