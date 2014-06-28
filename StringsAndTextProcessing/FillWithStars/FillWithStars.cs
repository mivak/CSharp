namespace FillWithStars
{
    using System;
    
    public class FillWithStars
    {
        public static void Main()
        {
            // Write a program that reads from the console a string of maximum 20 characters. 
            // If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
            // Print the result string into the console.
            Console.Write("Please enter a string of 20 characters or less: ");
            string star = Console.ReadLine();
            
            if (star.Length < 20)
            {
                string result = star + new string('*', 20 - star.Length);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(star);
            }
        }
    }
}