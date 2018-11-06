using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Products
{
    class Laptop : Product
    {
        public string Company { get; private set; }

        public Laptop(string name, string company, int price)
        {
            Name = name;
            Company = company;
            Price = price;
        }
    }
}
