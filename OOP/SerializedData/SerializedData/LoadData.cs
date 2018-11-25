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
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Чтение файла завершено");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            return data;
        }
    }
}
