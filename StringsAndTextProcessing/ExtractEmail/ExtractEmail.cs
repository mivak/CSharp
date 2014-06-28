namespace ExtractEmail
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmail
    {
        public static void Main()
        {
            /*Write a program for extracting all email addresses from given text. All substrings that match the 
            format <identifier>@<host>…<domain> should be recognized as emails.*/
            string givenText = " pesho@abv.bg sdjsss sadjsdj sadjsjdb aslsn sasdsa gosho@gmail.com asdksdb asdjasjd ivo@yahoo.com>";
            foreach (var item in Regex.Matches(givenText, @"\w+@\w+\.\w+"))
            {
                Console.WriteLine(item);
            }
        }
    }
}