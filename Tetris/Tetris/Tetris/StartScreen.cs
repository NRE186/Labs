using System;
using System.Linq;
using System.Text;

namespace Tetris
{
    class StartScreen
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            var pw = Console.WindowWidth / 2;
            Console.CursorTop = 10;
            Console.WriteLine("{0," + pw + "}", Title);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("{0," + (pw + 14 )+ "}", Description);
        }
    }
}
