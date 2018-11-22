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
        public string Year { get; set; }
        public string Price { get; set; }
    }
}