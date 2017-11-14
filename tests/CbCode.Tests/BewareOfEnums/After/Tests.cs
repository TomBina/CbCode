using CbCode.Examples.BewareOfEnums.Before;
using NUnit.Framework;
using System;

namespace CbCode.Tests.BewareOfEnums.After
{
    public class Tests
    {
        [TestCaseSource("GetRoles")]
        public void User_WithAdministratorRole_GetsResource(Role role)
        {
            var user = new User(role);
            var resource = new Resource();
            var protectedResource = resource.Get(user);

            Assert.AreEqual("Some text", protectedResource);
        }

        private static Object[] GetRoles =>
            new object[] { Role.Manager, Role.Administrator };

        [Test]
        public void User_WithvisitorRole_ThrowsException()
        {
            var user = new User(Role.Guest);
            var resource = new Resource();

            Assert.Throws<InvalidOperationException>(() => resource.Get(user));
        }
    }
}
