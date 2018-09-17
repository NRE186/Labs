using System;
using System.Collections.Generic;


namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Photo[] photos = new Photo[5];
            photos[0].name = "Super";
            photos[0].price = 250;
            photos[0].show_cost = 100;
            photos[0].photo_cost = 350;

            photos[1].name = "Interesting";
            photos[1].price = 150;
            photos[1].show_cost = 120;
            photos[1].photo_cost = 340;

            photos[2].name = "Helplessness";
            photos[2].price = 450;
            photos[2].show_cost = 140;
            photos[2].photo_cost = 300;

            photos[3].name = "Goodness";
            photos[3].price = 455;
            photos[3].show_cost = 100;
            photos[3].photo_cost = 350;

            photos[4].name = "God";
            photos[4].price = 235;
            photos[4].show_cost = 80;
            photos[4].photo_cost = 100;
            
            foreach (Photo p in photos)
            {
                Console.Write(p.name + " ");
                Console.Write(p.price + " ");
                Console.Write(p.show_cost + " ");
                Console.Write(p.photo_cost + " ");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        struct Photo
        {
            public string name;
            public int price;
            public int show_cost;
            public int photo_cost;
        }
    }
}
