namespace DayOfTheWeek
{
    using System;

    public class DayOfTheWeek
    {
        public static void Main()
        {
            // Write a program that prints to the console which day of the week is today.
            // Use System.DateTime.
            var day = DateTime.Now.DayOfWeek;
            Console.WriteLine(day);
        }
    }
}