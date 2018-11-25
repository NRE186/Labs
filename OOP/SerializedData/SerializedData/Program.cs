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
            string json = load.LoadingData();
            Console.WriteLine("Brand  Model   Year   Price");
            Deserializable deserializable = new Deserializable();
            deserializable.DeserializableData(json);
            CarsList myCollection = new CarsList
            {
                Cars = new Car[3]
            };
            myCollection.Cars[0] = new Car()
            {
                Brand = "Mercedes",
                Model = "E-200 Coupe",
                Year = "2018",
                Price = "244400000"
            };
            myCollection.Cars[1] = new Car()
            {
                Brand = "Mercedes",
                Model = "G65",
                Year = "2018",
                Price = "443123453123"
            };
            myCollection.Cars[2] = new Car()
            {
                Brand = "Mercedes",
                Model = "C-180",
                Year = "2018",
                Price = "4531200"
            };    
            Serialized serialiezed = new Serialized();        
            string text = serialiezed.SerializedData(myCollection);
            CreateFile create = new CreateFile
            {
                Path = @"W:\C#\Labs\Labs\OOP\SerializedData\Files\",
                Text = text              
            };
            create.Create();
            Console.ReadKey();
        }
    }
}
