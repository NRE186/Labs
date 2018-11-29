using System;
using System.IO;
using System.Text;

namespace SerializedData
{
    public class CreateFile:MessageSender
    {
        public string Path { get; set; }
        public string Text { get; set; }
        public string FileName { get; set; }
        public void Create()
        {
            string file = Path + FileName + ".json";
            try{
                if (Text != "")
                {
                    if (File.Exists(file))
                    {
                        File.Delete(file);
                    }
                    using (FileStream fs = File.Create(file))
                    {
                        byte[] text = new UTF8Encoding(true).GetBytes(Text);
                        fs.Write(text, 0, text.Length);
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
