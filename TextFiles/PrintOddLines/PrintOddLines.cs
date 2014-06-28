namespace PrintOddLines
{
    using System;
    using System.IO;

    public class PrintOddLines
    {
        public static void Main()
        {
            // Write a program that reads a text file and prints on the console its odd lines.
            StreamReader reader = new StreamReader("../../text.txt");
            using (reader)
            {
                int lineNumber = 1;
                string line = reader.ReadLine();
                while (line != null)
                {
                    reader.ReadLine();
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = reader.ReadLine();

                    lineNumber += 2;
                }
            }
        }
    }
}