using System;
using System.IO;
using System.Text;

namespace SerializedData
{
    class CreateFile:MessageSender
    {
        public string Path { get; set; }
        public string Text { get; set; }
        public string FileName { get; set; }
        public void Create()
        {
            string file = Path + FileName + ".json";
            try{
                if (File.Exists(file))
                {
                    File.Delete(file);
                }
                using (FileStream fs = File.Create(file))
                {
                    byte[] text = new UTF8Encoding(true).GetBytes(Text);
                    fs.Write(text, 0, text.Length);
                }
                Console.WriteLine("Файл {0}.json успешно создан", FileName);
                //TODO:
                //Right method for MessageSend
                //MessageSend("Green", "Файл {0}.json успешно создан", FileName);
            }
            catch(Exception e)
            {
                MessageSend("Red", e.Message);
            }
        }
    }
}
