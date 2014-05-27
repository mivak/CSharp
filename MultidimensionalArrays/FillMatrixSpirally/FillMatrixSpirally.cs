//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
//  1  2  3 4
// 12 13 14 5
// 11 16 15 6
// 10  9  8 7

namespace FillMatrixSpirally
{
    using System;
    class FillMatrixSpirally
    {

        static void Main()
        {
            Console.Write("Please enter the size of the matrix: ");
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int row = 0;
            int col = 0;
            string direction = "right";
            int maxRotations = size * size;

            for (int i = 1; i <= maxRotations; i++)
            {
                if (direction == "right" && (col > size - 1 || matrix[row, col] != 0))
                {
                    direction = "down";
                    col--;
                    row++;
                }

                if (direction == "down" && (row > size - 1 || matrix[row, col] != 0))
                {
                    direction = "left";
                    row--;
                    col--;
                }

                if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    direction = "up";
                    col++;
                    row--;
                }

                if (direction == "up" && row < 0 || matrix[row, col] != 0)
                {
                    direction = "right";
                    row++;
                    col++;
                }

                matrix[row, col] = i;

                if (direction == "right")
                {
                    col++;
                }

                if (direction == "down")
                {
                    row++;
                }

                if (direction == "left")
                {
                    col--;
                }

                if (direction == "up")
                {
                    row--;
                }
            }

            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    Console.Write("{0,4}", matrix[r, c]);
                }

                Console.WriteLine();
            }
        }
    }
}