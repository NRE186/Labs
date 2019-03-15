using System;
using System.IO;
using System.Text;

namespace SerializedData
{
    public class CreateFile:MessageSender
    {
        public string Text { get; set; }
        public string FileName { get; set; }
        public void Create()
        {
            string path = @"Отчёт\";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            string file = path + FileName + ".json";
            try{
                if (Text != "")
                {
                    using (StreamWriter sw = new StreamWriter(file, true, System.Text.Encoding.Default))
                    {
                        sw.WriteLine("Writing");
                        sw.Write(4.5);
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Файл {0}.json успешно создан", FileName);
                    Console.ResetColor();
                }
                else
                {
                    MessageSend("Red","Невозможно создать файл");
                }
            }
            catch(Exception e)
            {
                MessageSend("Red", e.Message);
            }
        }
    }
}
