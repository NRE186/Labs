using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 31;
            StartScreen screen = new StartScreen
            {
                Title = "TETRIS",
                Description = "Для начала игры нажмите Enter"
            };
            screen.Show();
            Game game = new Game
            {
                Speed = 1
            };
            if (Console.ReadKey().KeyChar == (char)13)
            {
                game.StartGame();
            }
            Console.ReadKey();
        }
    }
}
