namespace Task8LongestNonDecreasingSubsequence
{
    using System;
    using System.Collections.Generic;

    public class Task8LongestNonDecreasingSubsequence
    {
        public static void Main()
        {
            /*Write a program that reads a sequence of integers and finds in it the longest
             * non-decreasing subsequence. In other words, you should remove a minimal number
             * of numbers from the starting sequence, so that the resulting sequence is non-decreasing. 
             * In case of several longest non-decreasing sequences, print the leftmost of them. 
             * The input and output should consist of a single line, holding integer numbers separated by a space.*/

            Console.WriteLine("Please enter some numbers separated by a single space");
            string text = Console.ReadLine();
            char[] separators = { ' ' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            List<int> numbers = new List<int>();
            List<int> sequence = new List<int>();
            List<int> maxSequence = new List<int>();

            for (int i = 0; i < words.Length; i++)
            {
                numbers.Add(int.Parse(words[i]));
            }
            
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                int current = numbers[i];
                sequence.Add(numbers[i]);

                for (int j = i; j < numbers.Count - 1; j++)
                {
                    if (current <= numbers[j + 1])
                    {
                        sequence.Add(numbers[j + 1]);
                        current = numbers[j + 1];
                    }
                }

                if (sequence.Count > maxSequence.Count)
                {
                    maxSequence = new List<int>();
                    maxSequence.Add(sequence[0]);
                    for (int k = 0; k < sequence.Count - 1; k++)
                    {
                        if (sequence[k] <= sequence[k + 1])
                        {
                            maxSequence.Add(sequence[k + 1]);
                        }
                
                        numbers.Remove(sequence[k + 1]);
                    }
                }

                sequence = new List<int>();
            }

            for (int i = 0; i < maxSequence.Count; i++)
            {
                Console.Write(maxSequence[i] + " ");
            }
        }
    }
}