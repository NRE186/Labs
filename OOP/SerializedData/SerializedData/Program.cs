using System;

namespace SerializedData
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageSender sender = new MessageSender();
            LoadData load = new LoadData
            {
                Path = @"W:\C#\Labs\Labs\OOP\SerializedData\Files\bmw.json"
            };
            if (!(load is null))
            {
                string json = load.LoadingData();
                Console.WriteLine("Brand  Model   Year   Price");
                Deserializable deserializable = new Deserializable();
                if (!(deserializable is null))
                {
                    deserializable.DeserializableData(json);
                }
                else
                {
                    sender.MessageSend("Red", "deserializable is null");
                }
            }
            else
            {
                sender.MessageSend("Red", "load is null");
            }
            UserMessage userMessage = new UserMessage
            {
                Name = "Name",
                Message = "Text",
                Date = DateTime.Now.Date
            };
            if (!(userMessage is null))
            {
                Serialized serialiezed = new Serialized();
                if (!(serialiezed is null))
                {
                    string text = serialiezed.SerializedData(userMessage);
                    CreateFile create = new CreateFile
                    {
                        Text = text,
                        FileName = "user"
                    };
                    if (!(serialiezed is null))
                    {
                        create.Create();
                    }
                    else
                    {
                        sender.MessageSend("Red", "create is null");
                    }
                }
                else
                {
                    sender.MessageSend("Red", "serializable is null");
                }
            }
            else
            {
                sender.MessageSend("Red", "myCollection is null");
            }
            Console.ReadKey();
        }
    }
}
