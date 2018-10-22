using System;
using System.Collections.Generic;
using System.Linq;

namespace GameBC
{
    public class BC
    {
        int bulls, cows;
        char[] enigma;
        Random rnd = new Random(DateTime.Now.Millisecond);
        public readonly List<string> History = new List<string>();

        static void Swap<T>(ref T a, ref T b)
        {
            var t = a; a = b; b = t;
        }

        public BC()
        {
            enigma = Enumerable.Range(0, 10)
                .Select(x => (char)('0' + x))
                .ToArray();
        }

        internal void Step(string query)
        {
            string answ;
            if (query.Length == 4 &&
                query.All(ch => char.IsDigit(ch)) &&
                query.GroupBy(x => x).Count() == 4)
            {
                bulls = 0; cows = 0;
                for (int i = 0; i < 4; i++)
                    if (enigma[i] == query[i]) bulls++;
                    else if (enigma.Take(4).Contains(query[i])) cows++;
                answ = $"Быки - {bulls}, Коровы - {cows}";
            }
            else answ = "Нужно ввести четыре разные цифры";
            History.Add(query + " " + answ);
        }

        internal bool IsGameOver()
        {
            return bulls == 4;
        }

        public void NewGame()
        {
            for (int i = 0; i < 4; i++)
                Swap(ref enigma[i], ref enigma[rnd.Next(i, 10)]);
            History.Clear();
        }
    }
}
