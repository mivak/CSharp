namespace Task4DifferenceBetweenDates
{
    using System;
    
    public class Task4DifferenceBetweenDates
    {
        public static void Main()
        {
            // Write a program that enters two dates in format dd.MM.yyyy 
            // and returns the number of days between them.
            Console.Write("First date: ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Second date: ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(Math.Abs(firstDate.Subtract(secondDate).Days));
        }
    }
}