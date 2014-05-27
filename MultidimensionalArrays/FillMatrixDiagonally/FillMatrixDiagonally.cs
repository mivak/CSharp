//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
// 7 11 14 16
// 4  8 12 15
// 2  5  9 13
// 1  3  6 10

namespace FillMatrixDiagonally
{
    using System;

    class FillMatrixDiagonally
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int currentDigit = 1;

            for (int i = 1; i < size + 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    matrix[size - i + j, j] = currentDigit;
                    currentDigit++;
                }
            }

            for (int i = size - 2; i >= 0; i--)
            {
                for (int j = i; j >= 0; j--)
                {
                    matrix[i - j, size - j - 1] = currentDigit;
                    currentDigit++;
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0,3}", matrix[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}