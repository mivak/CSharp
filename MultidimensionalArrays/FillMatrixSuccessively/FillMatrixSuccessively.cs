//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
// 1 5 9 13
// 2 6 10 14
// 3 7 11 15
// 4 8 12 16

namespace FillMatrixSuccessively
{
    using System;
    class FillMatrixSuccessively
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = i + 1 + j * size;
                    Console.Write("{0} ", matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}