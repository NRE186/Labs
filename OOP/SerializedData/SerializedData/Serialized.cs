using Newtonsoft.Json;

namespace SerializedData
{
    public class Serialized
    {
        public string SerializedData(object collection)
        {
            string serialized = JsonConvert.SerializeObject(collection);
            return serialized;
        }
    }
}
