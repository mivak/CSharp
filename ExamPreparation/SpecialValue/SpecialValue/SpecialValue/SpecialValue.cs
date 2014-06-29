﻿namespace SpecialValue
{
    using System;

    public class SpecialValue
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[][] field = new int[n][];
            ReadData(field);
            bool[][] used = new bool[n][];

            for (int i = 0; i < n; i++)
            {
                used[i] = new bool[field[i].Length];
            }

            long max = long.MinValue;
            for (int i = 0; i < field[0].Length; i++)
            {
                long specialValue = FindCurrentSpecialValue(field, i, used);
                if (max < specialValue)
                {
                    max = specialValue;
                }
            }

            Console.WriteLine(max);
        }

        private static int[][] ReadData(int[][] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                string[] currentLine = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                field[i] = new int[currentLine.Length];

                for (int l = 0; l < currentLine.Length; l++)
                {
                    field[i][l] = int.Parse(currentLine[l]);
                }
            }

            return field;
        }

        private static long FindCurrentSpecialValue(int[][] field, int column, bool[][] used)
        {
            long result = 0;
            int currentRow = 0;
            while (true)
            {
                result++;
                if (used[currentRow][column])
                {
                    return long.MinValue;
                }
                
                if (field[currentRow][column] < 0)
                {
                    result -= field[currentRow][column];
                    return result;
                }
                
                int nextColumn = field[currentRow][column];
                used[currentRow][column] = true;
                column = nextColumn;
                currentRow++;
                
                if (currentRow == field.GetLength(0))
                {
                    currentRow = 0;
                }
            }
        }
    }
}