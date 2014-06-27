namespace Task3MinMaxSumAndAverageOfNNumbers
{
    using System;

    public class Task3MinMaxSumAndAverageOfNNumbers
    {
        public static void Main()
        {
            /*Write a program that reads from the console a sequence of n integer numbers and returns
             * the minimal, the maximal number, the sum and the average of all numbers 
             * (displayed with 2 digits after the decimal point). The input starts by the number n (alone in a line)
             * followed by n lines, each holding an integer number. The output is like in the examples below.*/

            Console.Write("n = ");
            uint n = uint.Parse(Console.ReadLine());
            int[] array = new int[n];
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("number {0} = ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;
            int avg = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }

                if (array[i] > max)
                {
                    max = array[i];
                }

                sum += array[i];
            }

            avg = (int)(sum / n);

            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0}", avg);
        }
    }
}