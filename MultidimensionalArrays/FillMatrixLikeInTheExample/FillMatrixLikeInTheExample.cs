//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
// 1 8 9 16
// 2 7 10 15
// 3 6 11 14
// 4 5 12 13

namespace FillMatrixLikeInTheExample
{
    using System;
    class FillMatrixLikeInTheExample
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j % 2 != 0)
                    {
                        matrix[i, j] = -i + size + j * size;
                    }
                    else
                    {
                        matrix[i, j] = i + 1 + j * size;
                    }

                    Console.Write("{0} ", matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}