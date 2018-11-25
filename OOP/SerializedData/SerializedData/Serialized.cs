using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
