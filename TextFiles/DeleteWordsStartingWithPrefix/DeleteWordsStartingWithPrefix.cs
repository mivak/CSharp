namespace DeleteWordsStartingWithPrefix
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    public class DeleteWordsStartingWithPrefix
    {
        public static void Main()
        {
            // Write a program that deletes from a text file all words that start with the prefix "test".
            // Words contain only the symbols 0...9, a...z, A…Z, _.
            StreamReader reader = new StreamReader("../../test.txt");
            
            using (reader)
            {
                string line = reader.ReadLine();
                StreamWriter writer = new StreamWriter("../../new.txt");
                
                using (writer)
                {
                    while (line != null)
                    {
                        writer.WriteLine(Regex.Replace(line, @"\btest\w*\b", string.Empty));
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}