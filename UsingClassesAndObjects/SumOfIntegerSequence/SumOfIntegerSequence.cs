namespace SumOfIntegerSequence
{
    using System;

    public class SumOfIntegerSequence
    {
        public static void Main()
        {
            // You are given a sequence of positive integer values written into a string, separated by spaces. 
            // Write a function that reads these values from given string and calculates their sum. Example:
            // string = "43 68 9 23 318"  result = 461
            Console.Write("Please enter a sequence of positive integer values, written into a string: ");
            string sequence = Console.ReadLine();
            int sum = CalculateSum(sequence);
            Console.WriteLine(sum);
        }

        private static int CalculateSum(string sequence)
        {
            string currentSum = string.Empty;
            int sum = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                switch (sequence[i])
                {
                    case '1': currentSum += '1'; break;
                    case '2': currentSum += '2'; break;
                    case '3': currentSum += '3'; break;
                    case '4': currentSum += '4'; break;
                    case '5': currentSum += '5'; break;
                    case '6': currentSum += '6'; break;
                    case '7': currentSum += '7'; break;
                    case '8': currentSum += '8'; break;
                    case '9': currentSum += '9'; break;
                    case '0': currentSum += '0'; break;
                    default: sum += int.Parse(currentSum);
                        currentSum = string.Empty;
                        break;
                }
            }

            // Without this sum the program will not add the last number because there is no 
            // space after it.
            sum += int.Parse(currentSum);
            return sum;
        }
    }
}