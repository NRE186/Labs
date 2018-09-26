using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            PC[] pCs = new PC[5];
            pCs[0].proc = "Intel Core I-9";
            pCs[0].ram = "Kingston 2.3 Khz";
            pCs[0].pzu = "-";
            pCs[0].hdd = "4TB";
            pCs[0].videodrive = "RTX-2080";
            pCs[0].price = 125000;

            pCs[1].proc = "Intel Core I-7";
            pCs[1].ram = "Kingston 2.3 Khz";
            pCs[1].pzu = "-";
            pCs[1].hdd = "1TB";
            pCs[1].videodrive = "GTX-1080";
            pCs[1].price = 75000;

            pCs[2].proc = "Intel Core I-5";
            pCs[2].ram = "Kingston 2.3 Khz";
            pCs[2].pzu = "-";
            pCs[2].hdd = "500GB";
            pCs[2].videodrive = "RTX-2060";
            pCs[2].price = 100000;

            pCs[3].proc = "Intel Core I-5";
            pCs[3].ram = "Kingston 2.3 Khz";
            pCs[3].pzu = "-";
            pCs[3].hdd = "1TB";
            pCs[3].videodrive = "GTX-1050";
            pCs[3].price = 45000;

            pCs[4].proc = "Intel Core I-3";
            pCs[4].ram = "Kingston 2.3 Khz";
            pCs[4].pzu = "-";
            pCs[4].hdd = "250GB";
            pCs[4].videodrive = "-";
            pCs[4].price = 5000;

            List<PC> needed = new List<PC>();

            foreach (PC pc in pCs)
            {
                if (pc.price > 6000)
                {
                    needed.Add(pc);
                }
            }
            Console.WriteLine("Информация о компьютерах стоимость, которых < 6000 рублей");
            needed.ForEach(Print);
            Console.ReadKey();
        }

        private static void Print(PC obj)
        {
            Console.Write(obj.proc + " ");
            Console.Write(obj.ram + " ");
            Console.Write(obj.pzu + " ");
            Console.Write(obj.hdd + " ");
            Console.Write(obj.videodrive + " ");
            Console.Write(obj.price + " ");
            Console.WriteLine();
        }

        struct PC
        {
            public string proc;
            public string ram;
            public string pzu;
            public string hdd;
            public string videodrive;
            public int price;
        }
    }
}
