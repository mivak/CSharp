namespace Problem7SumOf5Numbers
{
    using System;

    public class Problem7SumOf5Numbers
    {
        public static void Main()
        {
            // Write a program that enters 5 numbers (given in a single line, separated by a space),
            // calculates and prints their sum. 
            string numbersAsString = Console.ReadLine();
            string[] numbers = numbersAsString.Split(' ');
            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += double.Parse(numbers[i]);
            }

            Console.WriteLine(sum);
        }
    }
}