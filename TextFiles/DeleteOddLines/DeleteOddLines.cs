namespace DeleteOddLines
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class DeleteOddLines
    {
        public static void Main()
        {
            // Write a program that deletes from given text file all odd lines. 
            // The result should be in the same file.
            StreamReader reader = new StreamReader("../../test.txt");
            List<string> evenLines = new List<string>();
            
            using (reader)
            {
                int lineNumber = 1;
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (lineNumber % 2 == 0)
                    {
                        evenLines.Add(line);
                    }

                    lineNumber++;
                    line = reader.ReadLine();
                }
            }

            StreamWriter writer = new StreamWriter("../../test.txt");
            using (writer)
            {
                for (int i = 0; i < evenLines.Count; i++)
                {
                    writer.WriteLine(evenLines[i]);
                }
            }
        }
    }
}