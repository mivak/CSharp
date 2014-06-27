namespace Task7MatrixOfPalindromes
{
    using System;
    using System.Text;

    public class Task7MatrixOfPalindromes
    {
        public static void Main()
        {
            // Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns:
            Console.Write("r = ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int cols = int.Parse(Console.ReadLine());
            string[,] palindromes = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(((char)(97 + i)).ToString() + ((char)(97 + j + i)).ToString() + ((char)(97 + i)).ToString() + " ");
                    palindromes[i, j] = sb.ToString();
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(palindromes[i, j]);
                }
 
                Console.WriteLine();
            }
        }
    }
}