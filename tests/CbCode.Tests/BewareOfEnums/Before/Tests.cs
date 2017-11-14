using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CbCode.Examples.BewareOfEnums.Before;
using NUnit.Framework;

namespace CbCode.Tests.BewareOfEnums.Before
{
    public class Tests
    {
        [Test]
        public void User_HasUndefinedRoleAfterCast()
        {
            var user = new User((Role)1000);
            var roleExists = Enum.IsDefined(typeof(Role), user.Role);

            Assert.IsFalse(roleExists);
        }

        [Test]
        public void User_WithAdministratorRole_GetsResource()
        {
            var user = new User(Role.Administrator);
            var resource = new Resource();
            var protectedResource = resource.Get(user);

            Assert.AreEqual("Some text", protectedResource);
        }
    }
}
