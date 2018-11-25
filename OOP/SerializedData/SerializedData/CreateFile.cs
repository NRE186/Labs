using System;
using System.IO;
using System.Text;

namespace SerializedData
{
    class CreateFile
    {
        public string Path { get; set; }
        public string Text { get; set; }

        public void Create()
        {
            string file = Path + "mercedes.json";
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
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Файл успешно создан");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            catch(Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
