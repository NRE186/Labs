using Newtonsoft.Json;
using System;

namespace SerializedData
{
    class Deserializable:MessageSender
    {
        public void DeserializableData(string json)
        {
            CarsList newCar = JsonConvert.DeserializeObject<CarsList>(json);
            if (!(newCar is null))
            {
                foreach (var car in newCar.Cars)
                {
                    Console.WriteLine(" " + car.Brand + "    " + car.Model + "     " + car.Year + "   " + car.Price);
                }
            }
            else
            {
                MessageSend("Red", "newCar is null");
            }
        }
    }
}
