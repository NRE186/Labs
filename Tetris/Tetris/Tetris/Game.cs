using System;
using System.Threading;

namespace Tetris
{
    class Game
    {
        public int Width = Console.WindowWidth;
        public int Height = Console.WindowHeight;

        public int Speed { get; set; }

        public void StartGame()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
            while (true)
            {
                Spawn();
            }
        }
        public void Spawn()
        {
            int x = 31;
            int[,] field = new int[Width, Height];
            while (field[41,1] != 1 && Console.CursorTop < 31)
            {
                int i = 0;
                Console.CursorLeft = Width / 2 + 1;
                field[Console.CursorLeft, Console.CursorTop] = 1;
                Console.Write(field[Console.CursorLeft, Console.CursorTop]);
                if (Console.CursorTop != x-1)
                {
                    for (; i < Width; i++)
                    {
                        //Thread.Sleep(5);
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.CursorLeft = i;
                        field[Console.CursorLeft, Console.CursorTop] = 0;
                        Console.Write(field[Console.CursorLeft, Console.CursorTop]);
                    }
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.CursorTop++;
                i = 0;
                if (Console.CursorTop == x)
                {
                    Console.CursorTop = 0;
                    x--;
                }
            }
        }
    }
}
