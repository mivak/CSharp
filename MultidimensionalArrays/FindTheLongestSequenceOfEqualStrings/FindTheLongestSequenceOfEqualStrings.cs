// We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of
// several neighbor elements located on the same line, column or diagonal.
// Write a program that finds the longest sequence of equal strings in the matrix.

namespace FindTheLongestSequenceOfEqualStrings
{
    using System;

    class FindTheLongestSequenceOfEqualStrings
    {
        static void Main()
        {
            Console.Write("Please enter the length of the rows ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter the length of the columns ");
            int m = int.Parse(Console.ReadLine());
            string[,] words = new string[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Please enter the string value of index [{0}, {1}] ", i, j);
                    words[i, j] = Console.ReadLine();
                }
            }

            int colSum = 0;
            int rowSum = 0;
            int diagSum = 0;
            int bestRowSum = 0;
            int bestColSum = 0;
            int bestDiagSum = 0;
            string row = string.Empty;
            string col = string.Empty;
            string diag = string.Empty;
            int leftDiagSum = 0;
            int bestLeftDiagSum = 0;
            string leftDiag = string.Empty;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    if (words[i, j] == words[i, j + 1])
                    {
                        rowSum += 1;
                        if (rowSum > bestRowSum)
                        {
                            bestRowSum = rowSum;
                            row = words[i, j];
                        }
                    }

                    if (words[i, j] == words[i + 1, j])
                    {
                        colSum += 1;
                        if (colSum > bestColSum)
                        {
                            bestColSum = colSum;
                            col = words[i, j];
                        }
                    }

                    if (words[i, j] == words[i + 1, j + 1])
                    {
                        diagSum += 1;
                        if (diagSum > bestDiagSum)
                        {
                            bestDiagSum = diagSum;
                            diag = words[i, j];
                        }
                    }
                }
            }

            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    if (words[i, j] == words[i - 1, j + 1])
                    {
                        leftDiagSum++;
                        if (leftDiagSum > bestLeftDiagSum)
                        {
                            bestLeftDiagSum = leftDiagSum;
                            leftDiag = words[i, j];
                        }
                    }
                }
            }

            if (bestColSum >= bestDiagSum)
            {
                if (bestColSum >= bestLeftDiagSum)
                {
                    if (bestColSum >= bestRowSum)
                    {
                        for (int i = 0; i < bestColSum; i++)
                        {
                            Console.Write("{0}", col);
                            if (i != bestColSum - 1)
                            {
                                Console.Write(',');
                            }
                        }

                        Console.WriteLine();
                    }
                }
            }
            else if (bestDiagSum >= bestLeftDiagSum)
            {
                if (bestDiagSum >= bestRowSum)
                {
                    for (int i = 0; i < bestDiagSum; i++)
                    {
                        Console.Write(diag);
                        if (i != bestDiagSum - 1)
                        {
                            Console.Write(',');
                        }
                    }

                    Console.WriteLine();
                }
            }

            if (bestLeftDiagSum >= bestRowSum)
            {
                if (bestLeftDiagSum >= bestColSum)
                {
                    if (bestLeftDiagSum >= bestDiagSum)
                    {
                        for (int i = 0; i < bestLeftDiagSum; i++)
                        {
                            Console.Write(leftDiag);
                            if (i != bestLeftDiagSum - 1)
                            {
                                Console.Write(',');
                            }
                        }

                        Console.WriteLine();
                    }
                }
            }
            else if (bestRowSum > bestDiagSum)
            {
                if (bestRowSum > bestColSum)
                {
                    for (int i = 0; i < bestRowSum; i++)
                    {
                        Console.Write(row);
                        if (i != bestRowSum - 1)
                        {
                            Console.Write(',');
                        }
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}