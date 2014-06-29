namespace TenRandomValues
{
    using System;

    public class TenRandomValues
    {
        public static void Main()
        {
            // Write a program that generates and prints to the console 10 random values in the range [100, 200].
            Random randomGenerator = new Random();
            for (int i = 0; i < 10; i++)
            {
                int randomNumber = randomGenerator.Next(100, 201);
                Console.WriteLine(randomNumber);
            }
        }
    }
}