using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CbCode.Examples.ImmutableObjects
{
    public class Product
    {
        public decimal Price { get; }

        public Product(decimal price)
        {
            Price = price;
        }

        public Product ChangePrice(decimal price) => new Product(price);
    }
}
