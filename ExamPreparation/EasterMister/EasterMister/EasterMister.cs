namespace EasterMister
{
    using System;

    public class EasterMister
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.Write(new string('.', number + 1));
            Console.Write(new string('*', number - 1));
            Console.WriteLine(new string('.', number + 1));

            for (int i = 1; i < number - i - 1; i++)
            {
                if (number + 1 - (2 * i) > 0)
                {
                    Console.Write(new string('.', number + 1 - (2 * i)));
                    Console.Write("*");
                }

                if (number >= 2 * i - 2)
                {
                     Console.Write(new string('.', number - 3 + 4 * i));
                }
                
                Console.Write("*");
                if (number + 1 - (2 * i) > 0)
                {
                    Console.WriteLine(new string('.', number + 1 - (2 * i)));
                }
            }

            if (number > 5)
            {
                int temp = 5;
                while (temp <= number + 2)
                {
                    Console.Write(".*");
                    Console.Write(new string('.', 3 * number - 3));
                    Console.WriteLine("*.");
                    temp += 2;
                }
            }

            for (int i = 1; i <= number + 1; i++)
            {
                if (i == number / 2 + 2)
                {
                    Console.Write(".*.");
                    int temp = 0;
                    while (temp < (3 * number - 4) / 2)
                    {
                        Console.Write("#.");
                        temp++;
                    }

                    Console.WriteLine("*.");
                    temp = 0;
                    Console.Write(".*#");
                    
                    while (temp < (3 * number - 4) / 2)
                    {
                        Console.Write(".#");
                        temp++;
                    }
                    
                    Console.WriteLine("*.");
                }
            }

            if (number > 5)
            {
                int temp = 5;
                while (temp <= number + 2)
                {
                    Console.Write(".*");
                    Console.Write(new string('.', 3 * number - 3));
                    Console.WriteLine("*.");
                    temp += 2;
                }
            }
            
            for (int i = (number - 2) / 2; i >= 1; i--)
            {
                if (number + 1 - (2 * i) > 0)
                {
                    Console.Write(new string('.', number + 1 - (2 * i)));
                    Console.Write("*");
                }
            
                if (number >= 2 * i - 2)
                {
                    Console.Write(new string('.', number - 3 + 4 * i));
                }
                
                Console.Write("*");
                if (number + 1 - (2 * i) > 0)
                {
                    Console.WriteLine(new string('.', number + 1 - (2 * i)));
                }
            }

            Console.Write(new string('.', number + 1));
            Console.Write(new string('*', number - 1));
            Console.WriteLine(new string('.', number + 1));
        }
    }
}