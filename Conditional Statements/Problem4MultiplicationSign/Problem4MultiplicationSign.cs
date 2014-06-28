namespace Problem4MultiplicationSign
{
    using System;
    
    public class Problem4MultiplicationSign
    {
        public static void Main()
        {
            // Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
            // Use a sequence of if operators. 
            Console.Write("first number = ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("second number = ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("third number = ");
            int thirdNumber = int.Parse(Console.ReadLine());

            if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
            {
                Console.WriteLine(0);
            }
            else if (firstNumber > 0)
            {
                if (secondNumber > 0 && thirdNumber > 0)
                {
                    Console.WriteLine("+");
                }
                else if (secondNumber < 0 && thirdNumber < 0)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
            else
            {
                if (secondNumber > 0 && thirdNumber > 0)
                {
                    Console.WriteLine("-");
                }
                else if (secondNumber < 0 && thirdNumber < 0)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("+");
                }
            }
        }
    }
}