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
                        string pattern = @"\d+";
                        if (!(System.Text.RegularExpressions.Regex.IsMatch(line, pattern)))
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

