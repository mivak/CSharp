namespace CorrectBrackets
{
    using System;

    public class CorrectBrackets
    {
        public static void Main()
        {
            // Write a program to check if in a given expression the brackets are put correctly.
            // Example of correct expression: ((a+b)/5-d).
            // Example of incorrect expression: )(a+b)).
            Console.Write("Please enter an expression: ");
            string expression = Console.ReadLine();
            int first = 0;
            int second = 0;
            
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    first++;
                }
                else if (expression[i] == ')')
                {
                    second++;
                }
                
                if (second > first)
                {
                    break;
                }
            }

            if (first == second)
            {
                Console.WriteLine("The brackets are put correctly");
            }
            else
            {
                Console.WriteLine("The brackets are not put correctly");
            }
        }
    }
}