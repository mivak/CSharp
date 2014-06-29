namespace MovingLetters
{
    using System;
    using System.Text;

    public class MovingLetters
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            StringBuilder builder = new StringBuilder();
            int maxWordLength = 0;
            int[] wordLength = new int[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                int temp = words[i].Length;
                wordLength[i] = temp;
                if (temp > maxWordLength)
                {
                    maxWordLength = temp;
                }
            }

            for (int i = 0; i < maxWordLength; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    int temp = wordLength[j] - 1 - i;
                    if (temp >= 0)
                    {
                        builder.Append(words[j][temp]);
                    }
                }
            }

            int l = builder.Length;
            for (int i = 0; i < l; i++)
            {
                char ch = builder[i];
                int pos = 0;

                if (char.IsUpper(ch))
                {
                    pos = ch - 'A' + 1; 
                }
                else
                {
                    pos = ch - 'a' + 1;
                }

                int newPos = (i + pos) % l;
                builder.Remove(i, 1);
                builder.Insert(newPos, ch);
            }

            Console.WriteLine(builder.ToString());
        }
    }
}