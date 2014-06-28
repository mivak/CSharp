namespace RemoveWordsFromAnotherFile
{
    using System;
    using System.IO;
    using System.Security;
    using System.Text.RegularExpressions;

    public class RemoveWordsFromAnotherFile
    {
        public static void Main()
        {
            // Write a program that removes from a text file all words listed in given another text file. 
            // Handle all possible exceptions in your methods.
            try
            {
                StreamReader reader = new StreamReader("../../test.txt");
                using (reader)
                {
                    string line = reader.ReadLine();
                    StreamWriter writer = new StreamWriter("../../afterTest.txt");
                    using (writer)
                    {
                        while (line != null)
                        {
                            writer.WriteLine(Regex.Replace(line, @"\b(" + string.Join("|", File.ReadAllLines("../../words.txt")) + @")\b", string.Empty));
                            line = reader.ReadLine();
                        }
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