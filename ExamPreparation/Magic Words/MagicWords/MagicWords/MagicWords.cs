namespace MagicWords
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MagicWords
    {
        public static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            List<string> words = new List<string>();

            for (int i = 0; i < length; i++)
            {
                words.Add(Console.ReadLine());
            }

            for (int i = 0; i < length; i++)
            {
                int index = words[i].Length % (length + 1);
                string word = words[i];
                words.Insert(index, word);

                if (index < i)
                {
                    words.RemoveAt(i + 1);
                }
                else
                {
                    words.RemoveAt(i);
                }
            }

            int maxLength = 0;
            for (int i = 0; i < length; i++)
            {
                if (maxLength < words[i].Length)
                {
                    maxLength = words[i].Length;
                }
            }

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < maxLength; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (words[j].Length > i)
                    {  
                        builder.Append(words[j][i]);
                    }
                }
            }

            Console.WriteLine(builder.ToString());
        }
    }
}