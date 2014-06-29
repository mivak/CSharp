namespace DrunkenNumbers
{
    using System;

    public class DrunkenNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int h = 0; h < n; h++)
            {
                int number = int.Parse(Console.ReadLine());
                string numberAsString = number.ToString();

                if (numberAsString.Length % 2 == 0)
                {
                    for (int k = 0; k < numberAsString.Length / 2; k++)
                    {
                        int digit = int.Parse(numberAsString[k].ToString());
                        leftSum += digit;
                    }

                    for (int j = numberAsString.Length / 2; j < numberAsString.Length; j++)
                    {
                        int digit = int.Parse(numberAsString[j].ToString());
                        rightSum += digit;
                    }
                }
                else
                {
                    for (int m = 0; m <= numberAsString.Length / 2; m++)
                    {
                        int digit = int.Parse(numberAsString[m].ToString());
                        leftSum += digit;
                    }

                    for (int y = numberAsString.Length / 2; y < numberAsString.Length; y++)
                    {
                        int digit = int.Parse(numberAsString[y].ToString());
                        rightSum += digit;
                    }
                }
            }

            if (leftSum > rightSum)
            {
                Console.WriteLine("M {0}", leftSum - rightSum);
            }
            else if (rightSum > leftSum)
            {
                Console.WriteLine("V {0}", rightSum - leftSum);
            }
            else
            {
                Console.WriteLine("No {0}", leftSum + rightSum);
            }
        }
    }
}