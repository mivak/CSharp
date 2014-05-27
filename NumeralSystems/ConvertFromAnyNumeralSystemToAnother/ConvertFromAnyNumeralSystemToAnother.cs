// Write a program to convert from any numeral system of given base s to any other numeral
// system of base d (2 ≤ s, d ≤  16).

namespace ConvertFromAnyNumeralSystemToAnother
{
    using System;

    class ConvertFromAnyNumeralSystemToAnother
    {
        private static string ReverseDigits(string numString)
        {
            string reversed = null;
            for (int i = 0; i < numString.Length; i++)
            {
                reversed += numString[numString.Length - 1 - i];
            }
            return reversed;
        }

        static void Main()
        {
            Console.Write("Please enter the system s you want to enter a number (s = [2;16]): ");
            int s = int.Parse(Console.ReadLine());
            if (2 < s || s > 16)
            {
                Console.WriteLine("Invalid value!!! Please make sure s = [2;16]");
            }
            else
            {
                Console.Write("Please enter the system d you want to convert your number to (d = [2;16]): ");
                int d = int.Parse(Console.ReadLine());
                if (d < 2 || d > 16)
                {
                    Console.WriteLine("Invalid value!!! Please make sure d = [2;16]");
                }
                else
                {
                    Console.Write("Please enter a number in {0} system: ", s);
                    string num = Console.ReadLine();
                    int number = 0;

                    for (int i = 0; i < num.Length; i++)
                    {
                        switch (num[i])
                        {
                            case 'A': number += 10 * (int)Math.Pow(s, num.Length - 1 - i); break;
                            case 'B': number += 11 * (int)Math.Pow(s, num.Length - 1 - i); break;
                            case 'C': number += 12 * (int)Math.Pow(s, num.Length - 1 - i); break;
                            case 'D': number += 13 * (int)Math.Pow(s, num.Length - 1 - i); break;
                            case 'E': number += 14 * (int)Math.Pow(s, num.Length - 1 - i); break;
                            case 'F': number += 15 * (int)Math.Pow(s, num.Length - 1 - i); break;
                            default: number += (num[i] - 48) * (int)Math.Pow(s, num.Length - 1 - i);
                                break;
                        }
                    }

                    string converted = string.Empty;
                    while (number > 0)
                    {
                        int remainder = number % d;
                        switch (remainder)
                        {
                            case 10: converted += 'A'; break;
                            case 11: converted += 'B'; break;
                            case 12: converted += 'C'; break;
                            case 13: converted += 'D'; break;
                            case 14: converted += 'E'; break;
                            case 15: converted += 'F'; break;
                            default: converted += remainder;
                                break;
                        }

                        number = number / d;
                    }

                    Console.WriteLine(ReverseDigits(converted));
                }
            }
        }
    }
}