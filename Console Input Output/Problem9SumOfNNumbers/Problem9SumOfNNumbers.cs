namespace Problem9SumOfNNumbers
{
    using System;
    
    public class Problem9SumOfNNumbers
    {
        public static void Main()
        {
            // Write a program that enters a number n and after that enters more n numbers and calculates and 
            // prints their sum. Note that you may need to use a for-loop.
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            
            for (int i = 0; i < n; i++)
            {
                Console.Write("Please enter the {0} number: ", i + 1);
                sum += double.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
        }
    }
}