namespace Dictionary
{
    using System;
    using System.Collections.Generic;

    public class Dictionary
    {
        public static void Main()
        {
            /*A dictionary is stored as a sequence of text lines containing words and their explanations.
            Write a program that enters a word and translates it by using the dictionary. Sample dictionary:
            .NET – platform for applications from Microsoft
            CLR – managed execution environment for .NET
            namespace – hierarchical organization of classes*/
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add(".NET", "platform for applications from Microsoft");
            dict.Add("CLR", "managed execution environment for .NET");
            dict.Add("namespace", "hierarchical organization of classes");
            Console.Write("Please enter a word from the list to translate it (.NET, CLR, namespace): ");
            string word = Console.ReadLine();
            string result = dict[word];
            Console.WriteLine(word + " " + "-" + " " + result);
        }
    }
}