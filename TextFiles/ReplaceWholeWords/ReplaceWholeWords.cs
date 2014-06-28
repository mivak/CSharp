namespace ReplaceWholeWords
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    public class ReplaceWholeWords
    {
        public static void Main()
        {
            // Modify the solution of the previous problem to replace only whole words (not substrings).
            StreamReader reader = new StreamReader("../../replace.txt");
            using (reader)
            {
                string text = reader.ReadLine();
                while (text != null)
                {
                    StreamWriter writer = new StreamWriter("../../finish.txt", true);
                    using (writer)
                    {
                        writer.WriteLine(Regex.Replace(text, @"\bstart\b", "finish"));
                    }

                    text = reader.ReadLine();
                }
            }
        }
    }
}