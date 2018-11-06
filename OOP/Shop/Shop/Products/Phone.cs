using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Products
{
    class Phone : Product
    {
        public string Company { get; private set; }

        public Phone(string name, string company, int price)
        {
            Name = name;
            Company = company;
            Price = price;
        }
    }
}
