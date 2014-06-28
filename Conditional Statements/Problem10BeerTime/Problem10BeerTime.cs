namespace Problem10BeerTime
{
    using System;

    public class Problem10BeerTime
    {
        public static void Main()
        {
            /*A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format
             * “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and
             * prints “beer time” or “non-beer time” according to the definition above or “invalid time” if 
             * the time cannot be parsed. Note that you may need to learn how to parse dates and times. */

            Console.Write("Please enter a time in format \"hh:mm tt\" ");
            DateTime time = DateTime.Parse(Console.ReadLine());
            DateTime t1 = Convert.ToDateTime("1:00 PM");
            DateTime t2 = Convert.ToDateTime("3:00 AM");

            if (DateTime.Compare(time, t1) > 0 || DateTime.Compare(time, t2) < 0)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
    }
}