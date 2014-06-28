namespace WordsContainedInAnotherFile
{
    using System;
    using System.IO;
    using System.Security;
    using System.Text.RegularExpressions;

    public class WordsContainedInAnotherFile
    {
        public static void Main()
        {
            // Write a program that reads a list of words from a file words.txt and finds how many times each
            // of the words is contained in another file test.txt. The result should be written in the file
            // result.txt and the words should be sorted by the number of their occurrences in descending order. 
            // Handle all possible exceptions in your methods.
            try
            {
                string[] words = File.ReadAllLines("../../words.txt");
                int[] values = new int[words.Length];
                StreamReader reader = new StreamReader("../../test.txt");
                using (reader)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        for (int i = 0; i < words.Length; i++)
                        {
                            values[i] += Regex.Matches(line, @"\b" + words[i] + @"\b").Count;
                        }

                        line = reader.ReadLine();
                    }
                }

                Array.Sort(values, words);
                StreamWriter writer = new StreamWriter("../../result.txt");
                using (writer)
                {
                    for (int i = words.Length - 1; i >= 0; i--)
                    {
                        writer.WriteLine("{0}: {1}", words[i], values[i]);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory not found");
            }
            catch (IOException)
            {
                Console.WriteLine("IOException");
            }
            catch (SecurityException)
            {
                Console.WriteLine("SecurityException");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("UnauthorizedAccessException");
            }
        }
    }
}