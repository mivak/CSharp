namespace InsertLineNumbers
{
    using System;
    using System.IO;
    using System.Text;

    public class InsertLineNumbers
    {
        public static void Main()
        {
            // Write a program that reads a text file and inserts line numbers in front of each of its lines.
            // The result should be written to another text file.
            StreamReader reader = new StreamReader("../../text1.txt");
            using (reader)
            {
                int lineNumber = 1;
                string line = reader.ReadLine();
                while (line != null)
                {
                    StreamWriter writer = new StreamWriter("../../LineNumbered.txt", true, Encoding.GetEncoding("windows-1251"));
                    using (writer)
                    {
                        writer.WriteLine("Line {0} {1}", lineNumber, line);
                    }

                    line = reader.ReadLine();
                    lineNumber++;
                }
            }
        }
    }
}