// Write methods to calculate minimum, maximum, average, sum and product of given set of 
// integer numbers. Use variable number of arguments.

namespace CalculateMinimumMaximumAverageSumOrProduct
{
    using System;

    class CalculateMinimumMaximumAverageSumOrProduct
    {
        private static int GetMinimum(int[] numbers)
        {
            int min = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }

            return min;
        }

        private static int GetMaximum(int[] numbers)
        {
            int max = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }

            return max;
        }

        private static decimal CalculateAverige(int[] numbers)
        {
            decimal average = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                average += numbers[i];
            }

            average = average / numbers.Length;
            return average;
        }

        private static int CalculateSum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        private static int CalculateProduct(int[] numbers)
        {
            int product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }

            return product;
        }

        static void Main()
        {
            Console.WriteLine("Please enter your choice.\nTo calculate minimum enter \"1\"");
            Console.WriteLine("To calculate maximum enter \"2\"");
            Console.WriteLine("To calculate average enter \"3\"");
            Console.WriteLine("To calculate sum enter \"4\"\nTo calculate product enter \"5\"");
            int choice = int.Parse(Console.ReadLine());
            Console.Write("Please enter the length of the sequence of numbers ");
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Please enter the value of {0} number ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            switch (choice)
            {
                case 1: int min = GetMinimum(numbers);
                    Console.WriteLine("The minimum of the set is {0}", min); break;
                case 2: int max = GetMaximum(numbers);
                    Console.WriteLine("The maximum of the set is {0}", max); break;
                case 3: decimal average = CalculateAverige(numbers);
                    Console.WriteLine("The average of the set is {0}", average); break;
                case 4: int sum = CalculateSum(numbers);
                    Console.WriteLine("The sum of the set is {0}", sum); break;
                case 5: int product = CalculateProduct(numbers);
                    Console.WriteLine("The product of the set is {0}", product); break;
                default: Console.WriteLine("Invalid choice, please try again!");
                    break;
            }
        }
    }
}