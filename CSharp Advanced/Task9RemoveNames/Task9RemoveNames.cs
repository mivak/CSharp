namespace Task9RemoveNames
{
    using System;

    public class Task9RemoveNames
    {
        public static void Main()
        {
            // Write a program that takes as input two lists of names and removes from 
            // the first list all names given in the second list. The input and output 
            // lists are given as words, separated by a space, each list at a separate line.
            Console.WriteLine("Please enter two lists, given as words, separated by a space, each list at a separate line");
            string firstText = Console.ReadLine();
            string secondText = Console.ReadLine();
            bool isSame;

            string[] firstNames = firstText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] secondNames = secondText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < firstNames.Length; i++)
            {
                isSame = true;
                for (int j = 0; j < secondNames.Length; j++)
                {
                    if (firstNames[i] == secondNames[j])
                    {
                        isSame = false;
                    }
                }

                if (isSame)
                {
                    Console.Write(firstNames[i] + " ");
                }
            }
        }
    }
}