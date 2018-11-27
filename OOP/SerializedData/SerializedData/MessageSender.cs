using System;

namespace SerializedData
{
    class MessageSender
    {
        public virtual void MessageSend(string color, string message)
        {
            var red = ConsoleColor.Red;
            var green = ConsoleColor.Green;
            if (color == "Red")
            {
                Console.ForegroundColor = red;
                Console.WriteLine(message);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = green;
                Console.WriteLine(message);
                Console.ResetColor();
            }
        }
    }
}
