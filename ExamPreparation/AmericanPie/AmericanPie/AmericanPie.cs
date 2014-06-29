namespace AmericanPie
{
    using System;
    using System.Numerics;

    public class AmericanPie
    {
        public static void Main()
        {
            BigInteger a = BigInteger.Parse(Console.ReadLine());
            BigInteger b = BigInteger.Parse(Console.ReadLine());
            BigInteger c = BigInteger.Parse(Console.ReadLine());
            BigInteger d = BigInteger.Parse(Console.ReadLine());
            BigInteger nominator = (a * d) + (c * b);
            BigInteger denominator = b * d;
          
            if (nominator >= denominator)
            {
                Console.WriteLine("{0:0.}", nominator / denominator);
            }
            else
            {   
                Console.WriteLine("{0:F20}", (decimal)nominator / (decimal)denominator);
            }

            Console.WriteLine("{0}/{1}", nominator, denominator);
        }
    }
}