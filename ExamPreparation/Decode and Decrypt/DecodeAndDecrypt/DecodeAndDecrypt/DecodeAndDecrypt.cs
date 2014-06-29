namespace DecodeAndDecrypt
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class DecodeAndDecrypt
    {
        public static void Main()
        {
            string roughData = Console.ReadLine();
            string extendRoughData = ExtendText(roughData);

            int cypherLength = GetCypherLength(roughData);

            string[] msgcypher = GetMsgCypher(extendRoughData, cypherLength);

            string cypher = msgcypher[0];
            string message = msgcypher[1];
            Console.WriteLine(Decrypt(cypher, message));
        }

        private static int GetCypherLength(string roughData)
        {
            List<char> length = new List<char>();

            for (int i = roughData.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(roughData[i]))
                {
                    length.Add(roughData[i]);
                }
                else
                {
                    break;
                }
            }

            length.Reverse();
            string number = new string(length.ToArray());
            int cypherLength = int.Parse(number);
            return cypherLength;
        }

        private static string Decrypt(string cypher, string message)
        {
            char[] charMessage = message.ToArray();
            if (message.Length < cypher.Length)
            {
                int messageIndex = 0;

                for (int i = 0; i < cypher.Length; i++)
                {
                    int currentChar = cypher[i] - 65;

                    charMessage[messageIndex] = (char)((currentChar ^ (charMessage[messageIndex] - 65)) + 65);
                    messageIndex++;
                    if (messageIndex > (message.Length - 1))
                    {
                        messageIndex = 0;
                    }
                }
            }
            else
            {
                int cypherIndex = 0;
                for (int i = 0; i < message.Length; i++)
                {
                    int currentChar = charMessage[i] - 65;
                    charMessage[i] = (char)((currentChar ^ (cypher[cypherIndex] - 65)) + 65);
                    cypherIndex++;
                    if (cypherIndex > (cypher.Length - 1))
                    {
                        cypherIndex = 0;
                    }
                }
            }

            return new string(charMessage);
        }

        private static string ExtendText(string text)
        {
            StringBuilder extendedText = new StringBuilder();
            List<char> charRepeats = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    charRepeats.Add(text[i]);
                }
                else if (charRepeats.Count > 0)
                {
                    int repeats = int.Parse(new string(charRepeats.ToArray()));
                    extendedText.Append(new string(text[i], repeats));
                    charRepeats.Clear();
                }
                else
                {
                    extendedText.Append(text[i]);
                }
            }

            return extendedText.ToString();
        }

        private static string[] GetMsgCypher(string extendedData, int cypherLength)
        {
            int messageEnd = extendedData.Length - cypherLength - 1;
            StringBuilder message = new StringBuilder();
            StringBuilder cypher = new StringBuilder();

            for (int i = 0; i < extendedData.Length; i++)
            {
                if (i <= messageEnd)
                {
                    message.Append(extendedData[i]);
                }
                else
                {
                    cypher.Append(extendedData[i]);
                }
            }

            return new string[] { cypher.ToString(), message.ToString() };
        }
    }
}