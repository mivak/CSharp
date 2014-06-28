namespace SquareMatrix
{
    using System;
    using System.IO;

    public class SquareMatrix
    {
        /*Write a program that reads a text file containing a square matrix of numbers and finds in the matrix
        an area of size 2 x 2 with a maximal sum of its elements. The first line in the input file contains
        the size of matrix N. Each of the next N lines contain N numbers separated by space. 
        The output should be a single number in a separate text file. Example:
                4
                2 3 3 4
                0 2 3 4			17
                3 7 1 2
                4 3 3 2
                                                                                        */
        public static void Main()
        {
            StreamReader read = new StreamReader("../../matrix.txt");
            StreamWriter write = new StreamWriter("../../output.txt");
            string line = null;
            string number = null;
            int sizeOfMatrix;
            int row = 0;
            int col = 0;

            using (read)
            {
                line = read.ReadLine();
                sizeOfMatrix = int.Parse(line);
                int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];

                while ((line = read.ReadLine()) != null)
                {
                    foreach (var symbol in line)
                    {
                        if (symbol != ' ')
                        {
                            number += symbol;
                        }
                        else
                        {
                            matrix[row, col] = int.Parse(number);
                            number = null;
                            col++;
                        }
                    }

                    matrix[row, col] = int.Parse(number);
                    col = 0;
                    row++;
                    number = null;
                }

                using (write)
                {
                    write.WriteLine(FindMaxSum(matrix));
                }
            }
        }

        private static int FindMaxSum(int[,] matrix)
        {
            int bestSum = int.MinValue;
            int currentSum = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (bestSum < currentSum)
                    {
                        bestSum = currentSum;
                    }

                    currentSum = 0;
                }
            }

            return bestSum;
        }
    }
}