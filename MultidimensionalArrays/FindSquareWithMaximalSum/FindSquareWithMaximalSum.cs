// Write a program that reads a rectangular matrix of size N x M and finds in it the 
// square 3 x 3 that has maximal sum of its elements.

namespace FindSquareWithMaximalSum
{
    using System;

    class FindSquareWithMaximalSum
    {
        static void Main()
        {
            Console.Write("Please enter the length of the rows ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Please enter the length of the columns ");
            int columns = int.Parse(Console.ReadLine());
            int[,] rectangularMatrix = new int[rows, columns];
            int bigestSum = int.MinValue;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("The index of the matrix[{0}, {1}] = ", i, j);
                    rectangularMatrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int row = 0;
            int column = 0;
            for (int i = 0; i < rows - 2; i++)
            {
                for (int j = 0; j < columns - 2; j++)
                {
                    int sum = rectangularMatrix[i, j] + rectangularMatrix[i, j + 1] + rectangularMatrix[i, j + 2] +
                        rectangularMatrix[i + 1, j] + rectangularMatrix[i + 1, j + 1] + rectangularMatrix[i + 1, j + 2] +
                        rectangularMatrix[i + 2, j] + rectangularMatrix[i + 2, j + 1] + rectangularMatrix[i + 2, j + 2];

                    if (sum > bigestSum)
                    {
                        bigestSum = sum;
                        row = i;
                        column = j;
                    }
                }
            }

            Console.WriteLine(bigestSum);
            Console.Write("{0} {1} {2}\n{3} {4} {5}\n{6} {7} {8}", rectangularMatrix[row, column], rectangularMatrix[row, column + 1], rectangularMatrix[row, column + 2],
                rectangularMatrix[row + 1, column], rectangularMatrix[row + 1, column + 1], rectangularMatrix[row + 1, column + 2],
                rectangularMatrix[row + 2, column], rectangularMatrix[row + 2, column + 1], rectangularMatrix[row + 2, column + 2]);
            Console.WriteLine();
        }
    }
}