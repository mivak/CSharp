namespace ExtractTextWithoutTags
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    public class ExtractTextWithoutTags
    {
        public static void Main()
        {
            // Write a program that extracts from given XML file all the text without the tags. Example:
            // <?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>
            // Games</instrest><interest>C#</instrest><interest> Java</instrest></interests></student>
            StreamReader reader = new StreamReader("../../file.xml");

            using (reader)
            {
                StreamWriter writer = new StreamWriter("../../output.xml");
                using (writer)
                {
                    string content = reader.ReadToEnd();
                    string file = Regex.Replace(content, "<(.*?)>", " ");
                    writer.WriteLine(file);
                }
            }
        }
    }
}