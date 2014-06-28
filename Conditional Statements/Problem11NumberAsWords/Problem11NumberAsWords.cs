namespace Problem11NumberAsWords
{
    using System;

    public class Problem11NumberAsWords
    {
        public static void Main()
        {
            // Write a program that converts a number in the range [0…999] to words,
            // corresponding to the English pronunciation. 
            Console.Write("Please enter a number in the range [0...999] ");
            int number = int.Parse(Console.ReadLine());
            int firstDigit = number / 100;
            int secondDigit = (number / 10) % 10;
            int thirdDigit = number % 10;

            if (number > 0 && number <= 999)
            {
                if (secondDigit == 0 && thirdDigit == 0)
                {
                    switch (firstDigit)
                    {
                        case 1: Console.Write("One hundred");
                            break;
                        case 2: Console.Write("Two hundred");
                            break;
                        case 3: Console.Write("Three hundred");
                            break;
                        case 4: Console.Write("Four hundred");
                            break;
                        case 5: Console.Write("Five hundred");
                            break;
                        case 6: Console.Write("Six hundred");
                            break;
                        case 7: Console.Write("Seven hundred");
                            break;
                        case 8: Console.Write("Eight hundred");
                            break;
                        case 9: Console.Write("Nine hundred");
                            break;
                    }
                }
                else
                {
                    switch (firstDigit)
                    {
                        case 1: Console.Write("One hundred and ");
                            break;
                        case 2: Console.Write("Two hundred and ");
                            break;
                        case 3: Console.Write("Three hundred and ");
                            break;
                        case 4: Console.Write("Four hundred and ");
                            break;
                        case 5: Console.Write("Five hundred and ");
                            break;
                        case 6: Console.Write("Six hundred and ");
                            break;
                        case 7: Console.Write("Seven hundred and ");
                            break;
                        case 8: Console.Write("Eight hundred and ");
                            break;
                        case 9: Console.Write("Nine hundred and ");
                            break;
                    }
                }

                if (secondDigit == 1)
                {
                    switch (thirdDigit)
                    {
                        case 1: Console.Write("eleven\n");
                            break;
                        case 2: Console.Write("twelve\n");
                            break;
                        case 3: Console.Write("thirteen\n");
                            break;
                        case 4: Console.Write("fourteen\n");
                            break;
                        case 5: Console.Write("fifteen\n");
                            break;
                        case 6: Console.Write("sixteen\n");
                            break;
                        case 7: Console.Write("seventeen\n");
                            break;
                        case 8: Console.Write("eighteen\n");
                            break;
                        case 9: Console.Write("nineteen\n");
                            break;
                        case 0: Console.Write("ten\n");
                            break;
                    }
                }
                else
                {
                    switch (secondDigit)
                    {
                        case 2: Console.Write("twenty ");
                            break;
                        case 3: Console.Write("Thirty ");
                            break;
                        case 4: Console.Write("Fourty ");
                            break;
                        case 5: Console.Write("Fifty ");
                            break;
                        case 6: Console.Write("Sixty ");
                            break;
                        case 7: Console.Write("Seventy ");
                            break;
                        case 8: Console.Write("Eighty ");
                            break;
                        case 9: Console.Write("Ninety ");
                            break;
                    }

                    switch (thirdDigit)
                    {
                        case 1: Console.WriteLine("One\n");
                            break;
                        case 2: Console.WriteLine("Two\n");
                            break;
                        case 3: Console.WriteLine("Three\n");
                            break;
                        case 4: Console.WriteLine("Four\n");
                            break;
                        case 5: Console.WriteLine("Five\n");
                            break;
                        case 6: Console.WriteLine("Six\n");
                            break;
                        case 7: Console.WriteLine("Seven\n");
                            break;
                        case 8: Console.WriteLine("Eight\n");
                            break;
                        case 9: Console.WriteLine("Nine\n");
                            break;
                        case 0: Console.WriteLine("\n");
                            break;
                    }
                }
            }
            else if (number == 0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}