namespace BatGoikoTower
{
    using System;

    public class BatGoikoTower
    {
        public static void Main()
        {
            int height = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < height; i++)
            {
                Console.Write(new string('.', height - i - 1));
                Console.Write("/");
                int crossbeam = 0;

                for (int j = 0; j < height; j++)
                {
                    crossbeam += j;
                    crossbeam++;

                    if (crossbeam == i)
                    {
                        break;
                    }
                }

                if (i == crossbeam)
                {
                    Console.Write(new string('-', 2 * crossbeam));
                }
                else
                {
                    Console.Write(new string('.', 2 * i));
                }
                
                Console.Write('\\');
                Console.WriteLine(new string('.', height - i - 1));
            }
        }
    }
}