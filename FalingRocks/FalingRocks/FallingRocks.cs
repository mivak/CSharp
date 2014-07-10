namespace FallingRocks
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    public class FallingRocks
    {
        public static void Main()
        {
            // Declare general signs, dimensions etc.
            char[] rocksSymbols = { '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
            ConsoleColor[] colors = 
            {
                ConsoleColor.Green,
                ConsoleColor.Blue,
                ConsoleColor.Red,
                ConsoleColor.Magenta,
                ConsoleColor.Cyan,
                ConsoleColor.White,
                ConsoleColor.Yellow
            };
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 50;
            int life = 3;
            int score = 0;
            int speed = 0;
            int level = 1;

            // Declare dwarf
            Rocks dwarf = new Rocks();
            dwarf.X = Console.WindowWidth / 2;
            dwarf.Y = Console.WindowHeight - 2;
            dwarf.Sign = "(0)";
            dwarf.Color = ConsoleColor.White;

            Random randomGenerator = new Random();

            // Declare list of rocks on line0
            List<Rocks> listOfFallingRocks = new List<Rocks>();

            while (true)
            {
                // Print dwarf on the last row
                Console.SetCursorPosition(dwarf.X, dwarf.Y);
                Console.ForegroundColor = dwarf.Color;
                Console.Write(dwarf.Sign);
                Console.ForegroundColor = ConsoleColor.Gray;

                // Generate rocks and print them on line 0
                for (int i = 0; i < randomGenerator.Next(0, 4); i++)
                {
                    Rocks fallingRocks = new Rocks();
                    fallingRocks.X = randomGenerator.Next(0, Console.WindowWidth);
                    fallingRocks.Y = 0;
                    fallingRocks.C = rocksSymbols[randomGenerator.Next(0, 10)];
                    fallingRocks.Color = colors[randomGenerator.Next(0, 7)];
                    listOfFallingRocks.Add(fallingRocks);

                    Console.SetCursorPosition(fallingRocks.X, fallingRocks.Y);
                    Console.ForegroundColor = fallingRocks.Color;
                    Console.Write(fallingRocks.C);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                // User's input
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo dwarfMovement = Console.ReadKey();

                    // Smooth dwarf movement
                    if (dwarfMovement.Key == ConsoleKey.LeftArrow)
                    {
                        if (dwarf.X - 1 >= 0)
                        {
                            dwarf.X--;
                        }
                    }

                    if (dwarfMovement.Key == ConsoleKey.RightArrow)
                    {
                        if (dwarf.X + 1 < Console.WindowWidth - 2)
                        {
                            dwarf.X++;
                        }
                    }
                }

                Thread.Sleep(150 - speed);
                Console.Clear();

                // Move rocks one line down
                List<Rocks> listOfRocksDown = new List<Rocks>();

                for (int j = 0; j < listOfFallingRocks.Count; j++)
                {
                    Rocks oldRock = listOfFallingRocks[j];
                    Rocks newRock = new Rocks();
                    newRock.X = oldRock.X;
                    newRock.Y = oldRock.Y + 1;
                    newRock.C = oldRock.C;
                    newRock.Color = oldRock.Color;

                    if ((newRock.X == dwarf.X && newRock.Y == dwarf.Y) || (newRock.X == dwarf.X + 1 && newRock.Y == dwarf.Y) || (newRock.X == dwarf.X + 2 && newRock.Y == dwarf.Y))
                    {
                        life--;
                        Console.SetCursorPosition(dwarf.X, dwarf.Y);
                        Console.ForegroundColor = ConsoleColor.Red;
                        listOfFallingRocks.Clear();
                        Console.Beep();
                        Console.Write("X");
                        Thread.Sleep(300);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }

                    if (life == 0)
                    {
                        Console.SetCursorPosition(0, Console.WindowHeight - 1);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Game over!Score->{0}.Lev->{1} ", score, level);
                        Console.SetCursorPosition(28, Console.WindowHeight - 1);
                        Console.Write("Press [enter] to exit");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    if (newRock.Y < Console.WindowHeight - 1)
                    {
                        listOfRocksDown.Add(newRock);
                    }
                }

                // Print rocks on lines1+
                listOfFallingRocks = listOfRocksDown;
                foreach (Rocks rock1 in listOfFallingRocks)
                {
                    Console.SetCursorPosition(rock1.X, rock1.Y);
                    Console.ForegroundColor = rock1.Color;
                    Console.Write(rock1.C);
                }

                Console.ForegroundColor = ConsoleColor.Gray;

                // Print additional info
                Console.SetCursorPosition(1, Console.WindowHeight - 1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Life -->{0} Score-->{1} Level-->{2}, Speed-->{3}", life, score, level, 150 + speed);
                Console.ForegroundColor = ConsoleColor.Gray;

                score++;
                if (score / 200 != (score - 1) / 200)
                {
                    level = level + 1;
                }

                speed = 10 * (score / 200);
            }
        }
    }
}