namespace SecretsOfNumbers
{
    using System;

    public class SecretsOfNumbers
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            int[] numberArr = new int[number.Length];

            for (int i = 0; i < numberArr.Length; i++)
            {
                numberArr[i] = number[i] - '0';
            }

            int specialSum = 0;
            bool even = false;
            for (int i = numberArr.Length-1; i >= 0; i--)
            {
                if (even)
	            {
                    specialSum += numberArr[i] * numberArr[i] * (numberArr.Length-i);    
	            }
                else 
                {
                    specialSum += numberArr[i] * (numberArr.Length - i) * (numberArr.Length - i);
                }
                
                even = !(even);
            }

            Console.WriteLine(specialSum);
            char[] sequence = new char[specialSum % 10];
            if (specialSum % 10 == 0)
            {
                Console.WriteLine("{0} has no secret alpha-sequence", number);
            }
            else
            {
                int r = specialSum % 26;
                for (int j = 0; j < specialSum % 10; j++)
                {
                    char firstLetter =(char)(r + 65);
                    sequence[j] = firstLetter;
                    Console.Write(sequence[j]);
                    r++;
                    
                    if (r == 26)
                    {
                        r = 0;
                    }       
                }
            }
        }
    }
}