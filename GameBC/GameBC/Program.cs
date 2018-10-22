using static System.Console;
using System;
using System.Threading;

namespace GameBC
{
    class Program
    {
        static DateTime startGame;
        static bool flag = false;

        static void Main()
        {
            var timer = new System.Timers.Timer(40);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();

            var bc = new BC();

            do
            {
                bc.NewGame();
                startGame = DateTime.Now;
                do
                {
                    while (flag) Thread.Sleep(10) ;
                    var query = ReadLine();
                    Clear();
                    bc.Step(query);
                    WriteLine(string.Join("\n", bc.History));
                } while (!bc.IsGameOver());

                WriteLine("Game Over! \ny/n?");
            } while (ReadKey().KeyChar == 'y');
        }

        private static void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            flag = true;
            var oldY = CursorTop;
            var oldX = CursorLeft;
            CursorLeft = 70;
            CursorTop = 0;
            Write((DateTime.Now - startGame).TotalSeconds.ToString("F2"));
            CursorLeft = oldX;
            CursorTop = oldY;
            flag = false;
        }
    }
}
