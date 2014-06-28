namespace SameAndDifferentLines
{
    using System;
    using System.IO;

    public class SameAndDifferentLines
    {
        public static void Main()
        {
            // Write a program that compares two text files line by line and prints the number of lines that are
            // the same and the number of lines that are different. Assume the files have equal number of lines.
            StreamReader reader = new StreamReader("../../text.txt");
            StreamReader secondReader = new StreamReader("../../text1.txt");
            int same = 0;
            int different = 0;
            string sameLines = null;
            string differentLines = null;

            using (reader)
            {
                using (secondReader)
                {
                    int lineNumber = 1;
                    string line = reader.ReadLine();
                    string secondFileLine = secondReader.ReadLine();

                    while (line != null)
                    {
                        line = reader.ReadLine();
                        secondFileLine = secondReader.ReadLine();
                        if (line == secondFileLine)
                        {
                            same++;
                            sameLines += " " + lineNumber;
                        }
                        else
                        {
                            different++;
                            differentLines += " " + lineNumber;
                        }
            
                        lineNumber++;
                    }
                }
            }

            Console.WriteLine("Same: {0}, sum: {1}\nDifferent: {2}, sum: {3}", sameLines, same, differentLines, different);
        }
    }
}