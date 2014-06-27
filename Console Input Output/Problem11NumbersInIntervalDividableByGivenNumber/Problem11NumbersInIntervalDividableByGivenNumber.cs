namespace Problem11NumbersInIntervalDividableByGivenNumber
{
    using System;

    public class Problem11NumbersInIntervalDividableByGivenNumber
    {
        public static void Main()
        {
            // Write a program that reads two positive integer numbers and prints how many numbers p exist 
            // between them such that the reminder of the division by 5 is 0.
            Console.Write("firstNumber = ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("secondNumber = ");
            int secondNumber = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}