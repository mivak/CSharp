namespace Tres4Numbers
{
    using System;
    using System.Numerics;
    using System.Text;

    public class Tres4Numbers
    {
        public static void Main()
        {

            BigInteger number = BigInteger.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("LON+");
            }
            else
            {
                string binary = "";
                while (number > 0)
                {
                    binary += number % 9;
                    number = number / 9;
                }

                StringBuilder tresnum = new StringBuilder();
                for (int i = binary.Length - 1; i >= 0; i--)
                {
                    switch (binary[i])
                    {
                        case '0': tresnum.Append("LON+");
                            break;
                        case '1': tresnum.Append("VK-");
                            break;
                        case '2': tresnum.Append("*ACAD");
                            break;
                        case '3': tresnum.Append("^MIM");
                            break;
                        case '4': tresnum.Append("ERIK|");
                            break;
                        case '5': tresnum.Append("SEY&");
                            break;
                        case '6': tresnum.Append("EMY>>");
                            break;
                        case '7': tresnum.Append("/TEL");
                            break;
                        case '8': tresnum.Append("<<DON");
                            break;
                    }
                }

                Console.WriteLine(tresnum.ToString());
            }
        }
    }
}