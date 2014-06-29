namespace Zerg
{
    using System;

    public class Zerg
    {
        public static void Main()
        {
            string zergMessage = Console.ReadLine();
            string currentDigit;
            long a = 0;
            long b = 0;
            int pow = zergMessage.Length / 4;

            for (int i = 0; i < zergMessage.Length; i += 4)
            {
                pow--;
                currentDigit = zergMessage.Substring(i, 4);
                a = ConvertDigitToInt(currentDigit);
                b += a * (long)Math.Pow(15, pow);
            }

            Console.WriteLine(b);
        }

        private static long ConvertDigitToInt(string currentDigit)
        {
            long result = 0;
            switch (currentDigit)
            {
                case "Rawr": result = 0;
                    break;
                case "Rrrr": result = 1;
                    break;
                case "Hsst": result = 2;
                    break;
                case "Ssst": result = 3;
                    break;
                case "Grrr": result = 4;
                    break;
                case "Rarr": result = 5;
                    break;
                case "Mrrr": result = 6;
                    break;
                case "Psst": result = 7;
                    break;
                case "Uaah": result = 8;
                    break;
                case "Uaha": result = 9;
                    break;
                case "Zzzz": result = 10;
                    break;
                case "Bauu": result = 11;
                    break;
                case "Djav": result = 12;
                    break;
                case "Myau": result = 13;
                    break;
                case "Gruh": result = 14;
                    break;
                default: throw new ArgumentException();
            }

            return result;
        }
    }
}