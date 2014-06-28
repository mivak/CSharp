namespace CipherXor
{
    using System;
    using System.Text;
    
    public class CipherXor
    {
        /*Write a program that encodes and decodes a string using given encryption key (cipher). 
            * The key consists of a sequence of characters. The encoding/decoding is done by performing XOR
            * (exclusive or) operation over the first letter of the string with the first of the key, 
            * the second – with the second, etc. When the last key character is reached, the next is the first.*/
        public static string EncoderDecoder(string message, string cipher)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < message.Length; i += cipher.Length)
            {
                for (int j = 0; j < cipher.Length; j++)
                {
                    if (i + j > message.Length - 1)
                    {
                        break;
                    }

                    char temp = (char)(message[i + j] ^ cipher[j]);
                    sb.Append(temp);
                }
            }

            return sb.ToString();
        }

        public static void Main(string[] args)
        {
            string message = "This is a very secret message!";
            string cipher = "password";

            string resultEncoded = EncoderDecoder(message, cipher);
            Console.WriteLine(resultEncoded);

            string resultDecoded = EncoderDecoder(resultEncoded, cipher);
            Console.WriteLine(resultDecoded);
        }
    }
}