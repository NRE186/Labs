namespace SerializedData
{
    class CarsList
    {
        public Car[] Cars { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
    }
}