using System;

namespace SerializedData
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadData load = new LoadData
            {
                Path = @"W:\C#\Labs\Labs\OOP\SerializedData\Files\bmw.json"
            };
            if (!(load is null))
            {
                string json = load.LoadingData();
                Console.WriteLine("Brand  Model   Year   Price");
                Deserializable deserializable = new Deserializable();
                if (!(deserializable is null))
                {
                    deserializable.DeserializableData(json);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("deserializable is null");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("load is null");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            CarsList myCollection = new CarsList
            {
                Cars = new Car[3]
            };
            if (!(myCollection is null))
            {

                myCollection.Cars[0] = new Car()
                {
                    Brand = "Lada",
                    Model = "2114",
                    Year = 2005,
                    Price = 222442
                };
                myCollection.Cars[1] = new Car()
                {
                    Brand = "Lada",
                    Model = "2110",
                    Year = 2003,
                    Price = 42542
                };
                myCollection.Cars[2] = new Car()
                {
                    Brand = "Lada",
                    Model = "2107",
                    Year = 2003,
                    Price = 454545
                };
                Serialized serialiezed = new Serialized();
                if (!(serialiezed is null))
                {
                    string text = serialiezed.SerializedData(myCollection);
                    CreateFile create = new CreateFile
                    {
                        Path = @"W:\C#\Labs\Labs\OOP\SerializedData\Files\",
                        Text = text,
                        FileName = "lada"
                    };
                    if (!(serialiezed is null))
                    {
                        create.Create();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("create is null");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("serialized is null");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("myCollection is null");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.ReadKey();
        }
    }
}
