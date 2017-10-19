using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CbCode.Examples.ShouldWeUseRepositories;
using NUnit.Framework;

namespace CbCode.Tests.ShouldWeUseRepositories
{
    public class Tests
    {
        [Test]
        public void CustomerRepository_ReturnsCustomers()
        {
            var repo = new CustomerRepository();

            var result = repo.GetAll();

            Assert.AreEqual(2, result.Count());
        }

        [Test]
        public void CustomerRepository_CanQuery()
        {
            var repo = new CustomerRepository();

            var result = repo.Query().FirstOrDefault(r => r.Name == "John");

            Assert.AreEqual("John", result.Name);
        }
    }
}
