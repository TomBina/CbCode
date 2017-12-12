using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CbCode.Examples.DesignPatterns.FacadePattern;
using NUnit.Framework;

namespace CbCode.Tests.DesignPatterns.FacadePattern
{
    public class Tests
    {
        [Test]
        public void CustomerService_AddsCustomer()
        {
            var database = new Database();
            var customerService = new CustomerService(database);

            var rowsAffected = customerService.Add("Tom", "tombina@outlook.com");
            
            Assert.AreEqual(1, rowsAffected);
        }

        [Test]
        public void CustomerServices_GetsCustomer()
        {
            var database = new Database();
            var customerService = new CustomerService(database);

            var customer = customerService.Get(1);

            Assert.AreEqual(1, customer.Id);
        }
    }
}
