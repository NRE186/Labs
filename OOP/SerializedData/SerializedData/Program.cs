using Newtonsoft.Json;
using System;

namespace SerializedData
{
    class Program
    {
        static void Main(string[] args)
        {
            //LoadData load = new LoadData();

            CarsList myCollection = new CarsList();
            myCollection.Cars = new Car[3];

            myCollection.Cars[0] = new Car()
            {
                Brand = "BMW",
                Model = "M2",
                Year = "2018",
                Price = "20000000"
            };
            myCollection.Cars[1] = new Car()
            {
                Brand = "BMW",
                Model = "M2",
                Year = "2018",
                Price = "20000000"
            };
            myCollection.Cars[2] = new Car()
            {
                Brand = "BMW",
                Model = "M2",
                Year = "2018",
                Price = "20000000"
            };

            string serialized = JsonConvert.SerializeObject(myCollection);
            Console.WriteLine(serialized);
            Console.WriteLine();

            CarsList newCar = JsonConvert.DeserializeObject<CarsList>(serialized);
            foreach (var car in newCar.Cars)
            {
                Console.WriteLine(car.Brand + " " + car.Model + "-" + car.Year + " " + car.Price + Environment.NewLine);
            }

            Console.ReadKey();
        }
    }
}
