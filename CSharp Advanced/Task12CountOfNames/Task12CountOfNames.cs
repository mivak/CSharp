namespace Task12CountOfNames
{
    using System;

    public class Task12CountOfNames
    {
        public static void Main()
        {
            // Write a program that reads a list of names and prints for each name how
            // many times it appears in the list. The names should be listed in alphabetical order.
            // Use the input and output format from the examples below.
            Console.WriteLine("Please enter a sequence of names separated by space");
            string text = Console.ReadLine();
            int counter = 1;
            string[] names = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Array.Sort(names);

            for (int i = 0; i < names.Length - 1; i++)
            {
                if (i == names.Length - 2)
                {
                    if (names[i] == names[i + 1])
                    {
                        counter++;
                        Console.WriteLine(names[i] + " -> " + counter);
                    }
                    else
                    {
                        if (names[i] == names[i - 1])
                        {
                            Console.WriteLine(names[i] + " -> " + counter);
                            counter = 1;
                        }

                        Console.WriteLine(names[i + 1] + " -> " + counter);
                        counter = 1;
                    }
                }
                else
                {
                    if (names[i] == names[i + 1])
                    {
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine(names[i] + " -> " + counter);
                        counter = 1;
                    }
                }
            }
        }
    }
}