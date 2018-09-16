using System;
using System.IO;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"W:\C#\Labs\Labs\Lab8\file.txt";

            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!line.Contains("1") && !line.Contains("2") && !line.Contains("3") && !line.Contains("4") && !line.Contains("5") && !line.Contains("6")
                            && !line.Contains("7") && !line.Contains("8") && !line.Contains("9") && !line.Contains("0"))
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}

