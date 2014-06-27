namespace Problem5FormattingNumbers
{
    using System;

    public class Problem5FormattingNumbers
    {
        public static void Main()
        {
            /*Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a 
             * floating-point c and prints them in 4 virtual columns on the console. Each column should 
             * have a width of 10 characters. The number a should be printed in hexadecimal, left aligned; 
             * then the number a should be printed in binary form, padded with zeroes, then the number b 
             * should be printed with 2 digits after the decimal point, right aligned; the number c should
             * be printed with 3 digits after the decimal point, left aligned.*/
            Console.Write("Please enter an integer number (0 <= a <= 500): ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Please enter a floating-point number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Please enter a floating-point number: ");
            double thirdNumber = double.Parse(Console.ReadLine());
            
            Console.WriteLine("{0,-10:X} | {1,-10} | {2,10:F2} | {3,-10:F3}", firstNumber, Convert.ToString(firstNumber, 2).PadLeft(10, '0'), secondNumber, thirdNumber);
        }
    }
}