namespace Fire
{
    using System;

    public class Fire
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write(new string('.', n / 2 - i));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', 2 * i - 2));
                Console.Write(new string('#', 1));
                Console.WriteLine(new string('.', n / 2 - i));
            }

            for (int i = 1; i <= n / 4; i++)
            {
                Console.Write(new string('.', i - 1));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', n - (2 * i)));
                Console.Write('#');
                Console.WriteLine(new string('.', i - 1));
            }

            Console.WriteLine(new string('-', n));
            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write(new string('.', i - 1));
                Console.Write(new string('\\', n / 2 + 1 - i));
                Console.Write(new string('/', n / 2 + 1 - i));
                Console.WriteLine(new string('.', i - 1));
            }
        }
    }
}