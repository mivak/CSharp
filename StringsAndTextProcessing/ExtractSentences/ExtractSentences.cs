namespace ExtractSentences
{
    using System;

    public class ExtractSentences
    {
        public static void Main()
        {
            // Write a program that extracts from a given text all sentences containing given word.
            // Example: The word is "in". The text is:
            // We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. 
            // So we are drinking all the day. We will move out of it in 5 days.
            // The expected result is:
            // We are living in a yellow submarine.
            // We will move out of it in 5 days.
            // Consider that the sentences are separated by "." and the words – by non-letter symbols.
            string givenText = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string searchedWord = "in";
            string[] sentences = givenText.Split('.');

            foreach (string sentence in sentences)
            {
                string trimmedSentence = sentence.Trim();
                string[] splitedSentence = new string[givenText.Length];
                splitedSentence = trimmedSentence.Split(' ', ',', '.', ';', ':', '!', '?', '(', ')');
                foreach (string word in splitedSentence)
                {
                    if (string.Compare(word, searchedWord, true) == 0)
                    {
                        Console.WriteLine("{0}.", trimmedSentence);
                    }
                }
            }

            Console.WriteLine();
        }
    }
}