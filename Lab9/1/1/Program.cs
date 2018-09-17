using System;
using System.Collections.Generic;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Committee[] committees = new Committee[8];
            committees[0].name = "Пётр";
            committees[0].surname = "Иванов";
            committees[0].patronymic = "Сергеевич";
            committees[0].address = "ул.Ленина";
            committees[0].number_pas = 600600;
            committees[0].serial_pas = 6666;

            committees[1].name = "Александр";
            committees[1].surname = "Семенов";
            committees[1].patronymic = "Владимирович";
            committees[1].address = "ул.Мира";
            committees[1].number_pas = 245567;
            committees[1].serial_pas = 2485;

            committees[2].name = "Дмитрий";
            committees[2].surname = "Рахманинов";
            committees[2].patronymic = "Сергеевич";
            committees[2].address = "ул.Бахилова";
            committees[2].number_pas = 144535;
            committees[2].serial_pas = 1245;

            committees[3].name = "Пётр";
            committees[3].surname = "Сергеев";
            committees[3].patronymic = "Сергеевич";
            committees[3].address = "ул.Энергетиков";
            committees[3].number_pas = 142534;
            committees[3].serial_pas = 1758;

            committees[4].name = "Пётр";
            committees[4].surname = "Семёнов";
            committees[4].patronymic = "Сергеевич";
            committees[4].address = "ул.Ленина";
            committees[4].number_pas = 453445;
            committees[4].serial_pas = 1234;
        
            committees[5].name = "Семён";
            committees[5].surname = "Иванов";
            committees[5].patronymic = "Алексеевич";
            committees[5].address = "ул.Мира";
            committees[5].number_pas = 123456;
            committees[5].serial_pas = 1488;

            committees[6].name = "Артём";
            committees[6].surname = "Сидоров";
            committees[6].patronymic = "Сергеевич";
            committees[6].address = "ул.Ленина";
            committees[6].number_pas = 642424;
            committees[6].serial_pas = 1475;

            committees[7].name = "Сергей";
            committees[7].surname = "Петров";
            committees[7].patronymic = "Михайлович";
            committees[7].address = "ул.Мира";
            committees[7].number_pas = 148354;
            committees[7].serial_pas = 6842;

            List<Committee> needed = new List<Committee>();
            string s = Console.ReadLine();

            foreach (Committee c in committees)
            {
                if (c.address.Contains(s))
                {
                    needed.Add(c);
                }
            }
            int x = needed.Count;
            Console.WriteLine();
            needed.ForEach(Print);
            Console.ReadKey();
        }

        private static void Print(Committee obj)
        {
                Console.Write(obj.name + " ");
                Console.Write(obj.surname + " ");
                Console.Write(obj.patronymic + " ");
                Console.Write(obj.address + " ");
                Console.Write(obj.number_pas + " ");
                Console.Write(obj.serial_pas + " ");
                Console.WriteLine();
        }

        struct Committee
        {
            public string name;
            public string surname;
            public string patronymic;
            public string address;
            public int number_pas;
            public int serial_pas;
        }
    }
}
