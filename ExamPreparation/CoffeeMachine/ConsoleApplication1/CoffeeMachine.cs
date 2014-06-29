namespace CoffeeMachine
{
    using System;
    using System.Globalization;
    using System.Threading;

    public class CoffeeMachine
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CurrentCulture;

            int tray1 = int.Parse(Console.ReadLine());
            int tray2 = int.Parse(Console.ReadLine());
            int tray3 = int.Parse(Console.ReadLine());
            int tray4 = int.Parse(Console.ReadLine());
            int tray5 = int.Parse(Console.ReadLine());
            decimal amount = decimal.Parse(Console.ReadLine());
            decimal price = decimal.Parse(Console.ReadLine());

            decimal machineSum = (decimal)((tray1 * 0.05) + (tray2 * 0.1) + (tray3 * 0.2) + (tray4 * 0.5) + tray5);
            if (price > amount)
            {
                Console.WriteLine("More {0:F2}", price - amount);
            }
            else if (machineSum > amount - price)
            {
                Console.WriteLine("Yes {0:F2}", machineSum + price - amount);
            }
            else
            {
                Console.WriteLine("No {0:F2}", amount - price - machineSum);
            }
        }
    }
}