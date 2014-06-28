namespace InsensitiveSearch
{
    using System;
    using System.Text.RegularExpressions;

    public class InsensitiveSearch
    {
        public static void Main()
        {
            // Write a program that finds how many times a substring is contained in a given text
            // (perform case insensitive search).
            // Example: The target substring is "in". The text is as follows:
            // We are living in an yellow submarine. We don't have anything else. 
            // Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
            // The result is: 9.
            Console.WriteLine("Please enter some text:");
            string text = Console.ReadLine();
            Console.WriteLine("Please enter the substring to check how many times it appears in the text:");
            string check = Console.ReadLine();
            Console.WriteLine(Regex.Matches(text, check, RegexOptions.IgnoreCase).Count);
        }
    }
}