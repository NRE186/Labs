using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Informer
    {
        public void Buy(User user, Product product)
        {
            double price = product.GetDiscountPrice(user);
            user.ReduceBalance(price);
            Console.WriteLine($"{user.Name} купил {product.Name} за {price}.");
        }
    }
}
