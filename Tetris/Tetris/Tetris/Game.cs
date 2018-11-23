using System;

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
            DrawArea();
            while (true)
            {
                Spawn();
            }
        }
        public void DrawArea()
        {
            Console.CursorTop = Height - 1;
            Console.Write(new String('-', Width));
            Console.CursorTop = 0;
            Console.CursorLeft = 0;
        }
        public void Spawn()
        {
            char[,] field = new char[Width, Height];
            while (Console.CursorTop != 30)
            {
                Console.CursorLeft = Width / 2 + 1;
                field[Console.CursorLeft, Console.CursorTop] = '#';
                Console.Write(field[Console.CursorLeft, Console.CursorTop]);
                Console.CursorTop++;
                field[Console.CursorLeft - 1, Console.CursorTop - 1] = '1';
                if (Console.CursorTop != 30)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(field[Console.CursorLeft - 1, Console.CursorTop - 1]);
                }
            }
        }
    }
}
