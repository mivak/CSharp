namespace ExtractDates
{
    using System;
    using System.Globalization;
    using System.Text.RegularExpressions;

    public class ExtractDates
    {
        public static void Main()
        {
            // Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
            // Display them in the standard date format for Canada.
            string str = "The dates 87347 3437 are 49.59  17.05.2012, 13.09.2014, 50.13.2012";

            DateTime date;
            foreach (Match item in Regex.Matches(str, @"\b\d{2}.\d{2}.\d{4}\b"))
            {
                if (DateTime.TryParseExact(item.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
                }
            }
        }
    }
}