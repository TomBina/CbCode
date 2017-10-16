using CbCode.Examples.ImmutableObjects;
using NUnit.Framework;
using System.Linq;

namespace CbCode.Tests.ImmutableObjects
{
    public class Tests
    {
        [Test]
        public void Test()
        {
            var price = 100m;
            var product = new Product(price);

            var customer = new Customer();
            customer.Order(product);

            var changedProduct = product.ChangePrice(50m);

            customer.UpdateOrder(product, changedProduct);

            Assert.AreEqual(changedProduct.Price, customer.Products.First().Price);
        }
    }
}
