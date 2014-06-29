namespace _9GagNumbers
{
    using System;
    using System.Numerics;
    using System.Text;

    public class _9GagNumbers
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == '-' && input[i + 1] == '!')
                {
                    builder.Append("0");
                    i++;
                }
                else if (input[i] == '*' && input[i + 1] == '*')
                {
                    builder.Append("1");
                    i++;
                }
                else if (input[i] == '&' && input[i + 1] == '&')
                {
                    builder.Append("3");
                    i++;
                }
                else if (input[i] == '&' && input[i + 1] == '-')
                {
                    builder.Append("4");
                    i++;
                }
                else if (input[i] == '!' && input[i + 1] == '-')
                {
                    builder.Append("5");
                    i++;
                }
                else if (input[i] == '!' && input[i + 1] == '!' && input[i + 2] == '!')
                {
                    builder.Append("2");
                    i += 2;
                }
                else if (input[i] == '&' && input[i + 1] == '*' && input[i + 2] == '!')
                {
                    builder.Append("7");
                    i += 2;
                }
                else if (input[i] == '*' && input[i + 1] == '!' && input[i + 2] == '!' && input[i + 3] == '!')
                {
                    builder.Append("6");
                    i += 3;
                }
                else
                {
                    builder.Append("8");
                    i += 5;
                }
            }

            string digits = builder.ToString();
            BigInteger number = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                
                number += (BigInteger)(digits[i] - 48) * (BigInteger)(BigInteger.Pow(9, digits.Length - 1 - i));
            }

            Console.WriteLine(number);
        }
    }
}