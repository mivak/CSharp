namespace BullsAndCows
{
    using System;

    public class BullsAndCows
    {
        public static void Main()
        {
            // Console.WriteLine("Please enter the secret number");
            int secretNumber = int.Parse(Console.ReadLine());

            // Console.WriteLine("Please enter b = ");
            int b = int.Parse(Console.ReadLine());
            
            // Console.WriteLine("Please enter c = ");
            int c = int.Parse(Console.ReadLine());
            bool solution = false;

            for (int i = 1; i < 9999; i++)
            {
                char[] digits = i.ToString().ToCharArray();
                if (digits.Length == 4 && digits[0] >= 1 && digits[1] >= 1 && digits[2] >= 1 && digits[3] >= 1)
                {
                    char[] secret = secretNumber.ToString().ToCharArray();
                    int bulls = 0;
                    int cows = 0;

                    for (int j = 0; j < secret.Length; j++)
                    {
                        if (secret[j] == digits[j])
                        {
                            bulls++;
                            secret[j] = '*';
                            digits[j] = '@';
                        }
                    }
                    
                    for (int secretIndex = 0; secretIndex < secret.Length; secretIndex++)
                    {
                        for (int digitsIndex = 0; digitsIndex < digits.Length; digitsIndex++)
                        {
                            if (secret[secretIndex] == digits[digitsIndex])
                            {
                                cows++;
                                secret[secretIndex] = '*';
                                digits[digitsIndex] = '@';
                            }
                        }
                    }
                    
                    if (bulls == b && cows == c)
                    {
                        if (solution)
                        {
                            Console.Write(string.Empty);
                        }
                    
                        if (i > 100 && i < 1000 && (i / 10) % 10 != 0)
                        {
                            Console.Write(" {0}", i);
                            solution = true;
                        }
                        
                        if (i > 1000 && i < 9999 && (i / 10) % 10 != 0 && (i / 100) % 10 != 0 && i % 10 != 0)
                        {
                            Console.Write(" {0}", i);
                            solution = true;
                        }
                    }
                }
            }

            if (!solution)
            {
                Console.WriteLine("No");
            }
        }
    }
}