using System;

namespace SerializedData
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadData load = new LoadData
            {
                Path = @"W:\C#\Labs\Labs\OOP\cars.json"
            };
            string json = load.LoadingData();
            Console.WriteLine("Brand  Model   Year   Price");
            Deserializable deserializable = new Deserializable();
            deserializable.DeserializableData(json);
            Console.ReadKey();
        }
    }
}
