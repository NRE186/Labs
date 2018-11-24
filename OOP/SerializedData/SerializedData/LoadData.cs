using System;
using System.IO;
using System.Text;

namespace SerializedData
{
    class LoadData
    {
        public string Path { get; set; }
        public string LoadingData()
        {
            string data = "";
            try
            {
                using (StreamReader sr = new StreamReader(Path, Encoding.Default))
                {
                    data = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return data;
        }
    }
}
