using System;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CbCode.Examples.ChainOfResponsibilityFunctional;
using NUnit.Framework;

namespace CbCode.Tests.ChainOfResponsibilityFunctional
{
    public class Tests
    {
        [Test]
        public void AddLinkCommand_Valid()
        {
            var command = new AddLinkCommand()
            {
                Name = "Google",
                Url = "http://www.google.com"
            };

            var validator = new AddLinkCommandValidator();
            var valid = validator.Validate(command);

            Assert.True(valid);
        }

        [Test]
        public void AddLinkCommand_InValid()
        {
            var command = new AddLinkCommand()
            {
                Name = null,
                Url = "http://www.google.com"
            };

            var validator = new AddLinkCommandValidator();
            var valid = validator.Validate(command);

            Assert.False(valid);
        }
    }
}