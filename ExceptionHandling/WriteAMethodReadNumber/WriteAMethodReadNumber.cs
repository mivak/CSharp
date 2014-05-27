/* Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end].
* If an invalid number or non-number text is entered, the method should throw an exception. 
* Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100*/

namespace WriteAMethodReadNumber
{
    using System;

    class WriteAMethodReadNumber
    {
        static int ReadNumber(int start, int end)
        {
            try
            {
                Random num = new Random();
                int number = num.Next(start, end + 1);

                if (number < start || number > end)
                {
                    throw new System.ArgumentOutOfRangeException("The number is not in the range!");
                }
                return number;
            }
            catch (FormatException)
            {

                throw;
            }
            catch (StackOverflowException)
            {
                throw;
            }
        }

        static void Main()
        {
            int start = 2;
            int end = 99;

            for (int i = 0; i < 10; i++)
            {
                int number = ReadNumber(start, end);
                start = number + 1;
                Console.WriteLine("a{0} = {1}", i + 1, number);
            }
        }
    }
}