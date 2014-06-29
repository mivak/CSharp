namespace Carpets
{
    using System;

    public class Carpets
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n / 2; i++)
            {
                int position = 1;
                while (position <= n + 1)
                {
                    if (position <= n / 2 - i || position > n / 2 + i)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (j % 2 == 0)
                            {
                                Console.Write("/");
                            }
                            else
                            {
                                Console.Write(" ");
                            }

                            position++;
                        }

                        for (int j = i; j > 0; j--)
                        {
                            if (j % 2 != 0)
                            {
                                Console.Write("\\");
                            }
                            else
                            {
                                Console.Write(" ");
                            }

                            position++;
                        }
                    }

                    position++;
                }
               
                Console.WriteLine();
            }

            for (int i = n / 2; i > 0; i--)
            {
                int position = 1;
                while (position <= n + 1)
                {
                    if (position <= n / 2 - i || position > n / 2 + i)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (j % 2 == 0)
                            {
                                Console.Write("\\");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
 
                            position++;
                        }

                        for (int j = i; j > 0; j--)
                        {
                            if (j % 2 != 0)
                            {
                                Console.Write("/");
                            }
                            else
                            {
                                Console.Write(" ");
                            }

                            position++;
                        }
                    }

                    position++;
                }

                Console.WriteLine();
            }
        }
    }
}