using CbCode.Examples.MutableObjects;
using NUnit.Framework;

namespace CbCode.Tests.MutableObjects
{
    public class Tests
    {
        [Test]
        public void OrderProduct()
        {
            var product = new Product();
            var customer = new Customer();

            customer.PlaceInCart(product);
            customer.CheckOut();

            Assert.AreEqual(100m, product.Price);
            Assert.AreEqual(0m, customer.Wallet);
        }

        [Ignore("Remove this to see demo")]
        [Test]
        public void OrderProductBug()
        {
            var product = new Product();
            var customer = new Customer();

            customer.PlaceInCart(product);

            var specialDiscount = true;

            if (specialDiscount)
                product.Price *= 0.5m;

            customer.CheckOut();

            Assert.AreEqual(50m, product.Price);
            Assert.AreEqual(50m, customer.Wallet);
        }
    }
}