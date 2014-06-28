namespace ReadSortAndSave
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class ReadSortAndSave
    {
        public static void Main()
        {
            /*Write a program that reads a text file containing a list of strings, sorts them and saves them 
             * to another text file. Example:
	            Ivan			George
	            Peter			Ivan
	            Maria			Maria
	            George			Peter
                                                                                    */
            StreamReader reader = new StreamReader("../../names.txt");
            using (reader)
            {
                List<string> names = new List<string>();
                string line = reader.ReadLine();

                while (line != null)
                {
                    names.Add(line);
                    line = reader.ReadLine();
                }

                string[] sorted = new string[names.Count];
                for (int i = 0; i < names.Count; i++)
                {
                    sorted[i] = names[i];
                }

                Array.Sort(sorted);
                StreamWriter writer = new StreamWriter("../../Sorted.txt");
                using (writer)
                {
                    for (int i = 0; i < sorted.Length; i++)
                    {
                        writer.WriteLine(sorted[i]);
                    }
                }
            }
        }
    }
}