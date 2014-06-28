namespace Problem6TheBiggestOfFiveNumbers
{
    using System;
    
    public class Problem6TheBiggestOfFiveNumbers
    {
        public static void Main()
        {
            // Write a program that finds the biggest of five numbers by using only five if statements.
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("d = ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("e = ");
            int e = int.Parse(Console.ReadLine());

            int biggest = int.MinValue;
            if (a > biggest)
            {
                biggest = a;
            }

            if (b > biggest)
            {
                biggest = b;
            }

            if (c > biggest)
            {
                biggest = c;
            }

            if (d > biggest)
            {
                biggest = d;
            }

            if (e > biggest)
            {
                biggest = e;
            }

            Console.WriteLine(biggest);
        }
    }
}