using Newtonsoft.Json;
using System;

namespace SerializedData
{
    class Deserializable
    {
        public void DeserializableData(string json)
        {
            CarsList newCar = JsonConvert.DeserializeObject<CarsList>(json);
            foreach (var car in newCar.Cars)
            {
                Console.WriteLine(" " + car.Brand + "    " + car.Model + "     " + car.Year + "   " + car.Price);
            }
        }
    }
}
