namespace Problem9PlayWithIntDoubleAndString
{
    using System;
    
    public class Problem9PlayWithIntDoubleAndString
    {
        public static void Main()
        {
            /*Write a program that, depending on the user’s choice, inputs an int, double or string variable.
             * If the variable is int or double, the program increases it by one. If the variable is a string,
             * the program appends "*" at the end. Print the result at the console. Use switch statement.*/

            Console.Write("For int enter i, for double enter d, for string enter s... ");
            char choice = char.Parse(Console.ReadLine());
            switch (choice)
            {
                case 'i': Console.Write("Please enter an int ");
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine(number + 1);
                    break;
                case 'd': Console.Write("Please enter a double ");
                    double num = double.Parse(Console.ReadLine());
                    Console.WriteLine(num + 1);
                    break;
                case 's': Console.Write("Please enter a string ");
                    string text = Console.ReadLine();
                    Console.WriteLine(text + "*");
                    break;
                default: Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}