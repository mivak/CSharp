namespace Tribonacci
{
    using System;
    using System.Numerics;

    public class Tribonacci
    {
        public static void Main()
        {
            BigInteger firstMember = int.Parse(Console.ReadLine());
            BigInteger secondMember = int.Parse(Console.ReadLine());
            BigInteger thirdMember = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            Console.WriteLine(firstMember);
            Console.WriteLine("{0} {1}", secondMember, thirdMember);
            BigInteger nextMember = 0;

            for (int i = 0; i < lines - 2; i++)
            {
                for (int j = 0; j < i + 3; j++)
                {
                    nextMember = firstMember + secondMember + thirdMember;
                    firstMember = secondMember;
                    secondMember = thirdMember;
                    thirdMember = nextMember;
                    Console.Write("{0} ", nextMember);
                }

                Console.WriteLine();             
            }
        }
    }
}