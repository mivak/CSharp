namespace CheckIfLeap
{
    using System;

    public class CheckIfLeap
    {
        public static void Main()
        {
            // Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
            Console.Write("Please enter an year: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Is {0} a leap year? {1}", year, DateTime.IsLeapYear(year));
        }
    }
}