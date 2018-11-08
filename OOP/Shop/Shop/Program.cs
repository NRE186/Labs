using Shop.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Vasya", 150000, 0);

            Console.WriteLine("Список товаров : ");
            Console.WriteLine(new String('-', 25));

            Phone phone = new Phone("Iphone X", "Apple", 65000);
            Console.WriteLine("Название :" + phone.Name);
            Console.WriteLine("Производитель :" + phone.Company);
            Console.WriteLine("Цена :" + phone.Price);
            Console.WriteLine(new String('-', 25));

            Laptop laptop = new Laptop("MacBook Pro", "Apple", 90000);
            Console.WriteLine("Название :" + laptop.Name);
            Console.WriteLine("Производитель :" + laptop.Company);
            Console.WriteLine("Цена :" + laptop.Price);
            Console.WriteLine(new String('-', 25));

            Product[] products = new Product[] { phone, laptop };
            Informer informer = new Informer();

            double sum = 0;
            while (user.Balance > sum)
            {
                Console.WriteLine();
                Console.WriteLine($"Здравствуйте {user.Name} ваш баланс {user.Balance}");

                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"Товар {i} {products[i].Name} по цене {products[i].Price}");
                    sum += products[i].Price;
                }
                Console.WriteLine("Выберите номер товара и нажмите Enter:");

                string str = Console.ReadLine();
                if (str != "")
                {
                    int productNumber = Convert.ToInt32(str);
                    if (productNumber >= 0 && productNumber < products.Length)
                    {
                        if (products[productNumber].Price < user.Balance)
                        {
                            informer.Buy(user, products[productNumber]);
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Таких товаров нет!");
                    }
                }
                else
                {
                    Console.WriteLine("Вы не ввели число");
                }
            }
            Console.WriteLine("Вы больше не можете покупать в нашем магазине");
            Console.ReadKey();
        }
    }
}
