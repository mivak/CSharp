namespace Task10JoinLists
{
    using System;
    using System.Collections.Generic;

    public class Task10JoinLists
    {
        public static void Main()
        {
            /*Write a program that takes as input two lists of integers and joins them. 
             * The result should hold all numbers from the first list, and all numbers 
             * from the second list, without repeating numbers, and arranged in increasing 
             * order. The input and output lists are given as integers, separated by a space, 
             * each list at a separate line.*/

            Console.WriteLine("Please enter two lists of integers, separated by a space, each list at a separate line");
            string firstText = Console.ReadLine();
            string secondText = Console.ReadLine();

            string[] firstNumbers = firstText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] secondNumbers = secondText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> num = new List<int>();

            for (int i = 0; i < firstNumbers.Length; i++)
            {
                num.Add(int.Parse(firstNumbers[i]));
            }

            for (int i = 0; i < secondNumbers.Length; i++)
            {
                num.Add(int.Parse(secondNumbers[i]));
            }

            num.Sort();

            HashSet<int> numbers = new HashSet<int>();

            for (int i = 0; i < num.Count; i++)
            {
                numbers.Add(num[i]);
            }

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}