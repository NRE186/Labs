using Newtonsoft.Json;

namespace SerializedData
{
    class Serialized
    {
        public string SerializedData(object collection)
        {
            string serialized = JsonConvert.SerializeObject(collection);
            return serialized;
        }
    }
}
