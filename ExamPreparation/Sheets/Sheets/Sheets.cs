namespace Sheets
{
    using System;

    public class Sheets
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] array = new int[11];
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (int)Math.Pow(2, array.Length - 1 - i);
                if (number < array[i])
                {
                    Console.WriteLine("A{0}", i);
                }
                else
                {
                    number -= array[i];
                }
            }
        }
    }
}