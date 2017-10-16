using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CbCode.Examples.ImmutableObjects
{
    public class Customer
    {
        private List<Product> _products = new List<Product>();
        public IEnumerable<Product> Products => _products;

        public void Order(Product product)
        {
            _products.Add(product);
        }

        public void UpdateOrder(Product oldProduct, Product newProduct)
        {
            var index = _products.IndexOf(oldProduct);
            _products[index] = newProduct;
        }
    }
}
