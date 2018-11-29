namespace SerializedData
{
    public class CarsList
    {
        public Car[] Cars { get; set; }
    }
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
    }
}