namespace Upcase
{
    using System;

    public class Upcase
    {
        public static void Main()
        {
            /*You are given a text. Write a program that changes the text in all regions surrounded by the tags
             * <upcase> and </upcase> to uppercase. The tags cannot be nested. Example:
            We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
            The expected result:
            We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.*/
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            int start = 0;
            int end = 0;
            Console.WriteLine(text);

            for (int i = 0; i < text.Length - 8; i++)
            {
                if (text.Substring(i, 8) == "<upcase>")
                {
                    start = i + 8;
                    i = start;
                }

                if (text.Substring(i, 9) == "</upcase>")
                {
                    end = i;
                    int length = end - start;
                    string upperStr = text.Substring(start, length).ToUpper();
                    text = text.Remove(start, length);
                    text = text.Insert(start, upperStr);
                    text = text.Remove(start - 8, 8);
                    text = text.Remove(end - 8, 9);
                }
            }

            Console.WriteLine(text);
        }
    }
}