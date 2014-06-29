namespace NextDate
{
    using System;

    public class NextDate
    {
        public static void Main()
        {
            byte day = byte.Parse(Console.ReadLine());
            byte month = byte.Parse(Console.ReadLine());
            short year = short.Parse(Console.ReadLine());
            
            if (month == 2)
            {
                if (year % 4 == 0)
                {
                    if (day == 28)
                    {
                        Console.WriteLine("29.2.{0}", year);
                    }
                    else if (day == 29)
                    {
                        Console.WriteLine("1.3.{0}", year);
                    }
                }
                else
                {
                    if (day == 28)
                    {
                        Console.WriteLine("1.3.{0}", year);
                    }
                    else
                    {
                        Console.WriteLine("{0}.{1}.{2}", day + 1, month, year);
                    }
                }
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (day == 30)
                {
                    Console.WriteLine("1.{0}.{1}", month + 1, year);
                }
                else
                {
                    Console.WriteLine("{0}.{1}.{2}", day + 1, month, year);
                }
            }
           else if (month == 12)
            {
               if (day == 31)
                    {
                        Console.WriteLine("1.1.{0}", year + 1);
                    }
               else
               {
                   Console.WriteLine("{0}.{1}.{2}", day + 1, month, year);
               }
            }
            else
            {
                if (day == 31)
                {
                    Console.WriteLine("1.{0}.{1}", month + 1, year);
                }
                else
                {
                    Console.WriteLine("{0}.{1}.{2}", day + 1, month, year);
                }
            }
        }
    }
}