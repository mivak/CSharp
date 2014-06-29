namespace ApplesOrOranges
{
    using System;

    public class ApplesOrOranges
    {
        public static void Main()
        {
            string numberAsString = Console.ReadLine();
            long number = long.Parse(numberAsString);
            int oddSum = 0;
            int evenSum = 0;

            if (number < 0)
            {
                number = Math.Abs(number);
            }

            for (int i = 0; i < numberAsString.Length; i++)
            {
                if ((number % 10) % 2 == 0)
                {
                    evenSum += (int)(number % 10);
                    number = number / 10;
                }
                else
                {
                    oddSum += (int)(number % 10);
                    number = number / 10;
                }
            }

            if (evenSum > oddSum)
            {
                Console.WriteLine("apples {0}", evenSum);
            }
            else if (evenSum < oddSum)
            {
                Console.WriteLine("oranges {0}", oddSum);
            }
            else
            {
                Console.WriteLine("both {0}", evenSum);
            }
        }
    }
}