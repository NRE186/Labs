using System;
using System.IO;
using System.Text;

namespace SerializedData
{
    public class LoadData:MessageSender
    {
        public string Path { get; set; }
        public string LoadingData()
        {
            if (Path.Contains(".json"))
            {
                string data = "";
                try
                {
                    using (StreamReader sr = new StreamReader(Path, Encoding.Default))
                    {
                        data = sr.ReadToEnd();
                    }
                    MessageSend("Green", "Чтение файла завершено");
                    if (data == "")
                    {
                        MessageSend("Red","Файл пуст");
                        data = "Файл пуст";
                    }
                    Console.WriteLine();
                    return data;
                }
                catch (Exception e)
                {
                    MessageSend("Red", e.Message);
                    return null;
                }
            }
            else
            {
                MessageSend("Red", "Файл имеет неправильное расширение");
                return null;
            }
        }
    }
}
