namespace ConcatenateTwoTextFiles
{
    using System;
    using System.IO;
    using System.Text;

    public class ConcatenateTwoTextFiles
    {
        public static void Main()
        {
            // Write a program that concatenates two text files into another text file.
            StreamReader reader = new StreamReader("../../text.txt");
            using (reader)
            {
                string firstFile = reader.ReadToEnd();
                StreamWriter writer = new StreamWriter("concatenated", false, Encoding.GetEncoding("windows-1251"));
                using (writer)
                {
                    writer.WriteLine(firstFile);
                }
            }

            reader = new StreamReader("../../text1.txt");
            using (reader)
            {
                string secondFile = reader.ReadToEnd();
                StreamWriter writer = new StreamWriter("../../concatenated.txt", true, Encoding.GetEncoding("windows-1251"));
                using (writer)
                {
                    writer.WriteLine(secondFile);
                }
            }
        }
    }
}