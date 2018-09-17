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
            Airport[] airports = new Airport[5];
            airports[0].number = 607;
            airports[0].dep_place = "Сургут";
            airports[0].dep_time = new DateTime(2018, 10, 25, 18, 00, 00);
            airports[0].ar_place = "Москва";
            airports[0].ar_time = new DateTime(2018, 10, 25, 18, 30, 00);

            airports[1].number = 789;
            airports[1].dep_place = "Москва";
            airports[1].dep_time = new DateTime(2018, 10, 25, 18, 00, 00);
            airports[1].ar_place = "Сочи";
            airports[1].ar_time = new DateTime(2018, 10, 25, 18, 30, 00);

            airports[2].number = 606;
            airports[2].dep_place = "Сургут";
            airports[2].dep_time = new DateTime(2018, 10, 25, 18, 00, 00);
            airports[2].ar_place = "Сочи";
            airports[2].ar_time = new DateTime(2018, 10, 25, 18, 30, 00);

            airports[3].number = 666;
            airports[3].dep_place = "Анапа";
            airports[3].dep_time = new DateTime(2018, 10, 25, 18, 00, 00);
            airports[3].ar_place = "Сургут";
            airports[3].ar_time = new DateTime(2018, 10, 25, 18, 30, 00);

            airports[4].number = 708;
            airports[4].dep_place = "Туапсе";
            airports[4].dep_time = new DateTime(2018, 10, 25, 18, 00, 00);
            airports[4].ar_place = "Сургут";
            airports[4].ar_time = new DateTime(2018, 10, 25, 18, 30, 00);

            List<Airport> needed = new List<Airport>();
            string s = Console.ReadLine();

            foreach (Airport a in airports)
            {
                if (a.ar_place.Contains(s))
                {
                    needed.Add(a);
                }
            }
            Console.WriteLine();
            Console.WriteLine("№   Место и время отправления  Место и время прибытия ");
            needed.ForEach(Print);
            Console.ReadKey();
        }

        private static void Print(Airport obj)
        {
            Console.Write(obj.number + " ");
            Console.Write(obj.dep_place + " ");
            Console.Write(obj.dep_time + " ");
            Console.Write(obj.ar_place + " ");
            Console.Write(obj.ar_time + " ");
            Console.WriteLine();
        }

        struct Airport
        {
            public int number;
            public string dep_place;
            public DateTime dep_time;
            public string ar_place;
            public DateTime ar_time;
        }
    }
}
