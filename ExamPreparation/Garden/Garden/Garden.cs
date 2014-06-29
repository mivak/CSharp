namespace Garden
{
    using System;

    public class Garden
    {
        public static void Main()
        {
            int totalArea = 250;
            decimal tomatoPrice = 0.5M;
            decimal cucumberPrice = 0.4M;
            decimal potatoPrice = 0.25M;
            decimal carrotPrice = 0.6M;
            decimal cabbagePrice = 0.3M;
            decimal beansPrice = 0.4M;
            
            int tomatoAmount = int.Parse(Console.ReadLine());
            int tomatoArea = int.Parse(Console.ReadLine());
            int cucumberAmount = int.Parse(Console.ReadLine());
            int cucumberArea = int.Parse(Console.ReadLine());
            int potatoAmount = int.Parse(Console.ReadLine());
            int potatoArea = int.Parse(Console.ReadLine());
            int carrotAmount = int.Parse(Console.ReadLine());
            int carrotArea = int.Parse(Console.ReadLine());
            int cabbageAmount = int.Parse(Console.ReadLine());
            int cabbageArea = int.Parse(Console.ReadLine());
            int beensAmount = int.Parse(Console.ReadLine());

            Console.WriteLine("Total costs: {0:F2}", tomatoPrice * tomatoAmount + cucumberPrice * cucumberAmount + potatoPrice * potatoAmount + 
                carrotPrice * carrotAmount + cabbagePrice * cabbageAmount + beansPrice * beensAmount);
            if (totalArea > tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea)
            {
                Console.WriteLine("Beans area: {0}", totalArea - (tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea));
            }
            else if (totalArea == tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea)
            {
                Console.WriteLine("No area for beans");
            }
            else
            {
                Console.WriteLine("Insufficient area");
            }
        }
    }
}