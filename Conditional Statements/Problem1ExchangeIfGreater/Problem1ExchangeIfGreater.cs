namespace Problem1ExchangeIfGreater
{
    using System;
    
    public class Problem1ExchangeIfGreater
    {
        public static void Main()
        {
            // Write an if-statement that takes two integer variables a and b and exchanges their values 
            // if the first one is greater than the second one. As a result print the values a and b, separated by a space. 
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            Console.WriteLine(a + " " + b);
        }
    }
}