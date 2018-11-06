using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class User
    {
        public string Name { get; private set; }
        public double Balance { get; private set; }
        public double Spent { get; private set; }
        
        public User(string name, double balance, double spent)
        {
            Name = Name;
            Balance = balance;
            Spent = spent;
        }
        public void ReduceBalance(double price)
        {
            Balance -= price;
            Spent += price;
        }
    }
}
