using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CbCode.Examples.ChainOfResponsibility.After;
using NUnit.Framework;

namespace CbCode.Tests.ChainOfResponsibility.After
{
    public class Tests
    {
        [Test]
        public void AddLinkCommand_Valid()
        {
            var addLinkCommand = new AddLinkCommand()
            {
                Name = "Google",
                Url = "http://www.google.com"
            };
            var urlValidator = new UrlValidator();
            var nameValidator = new NameValidator(maxLength: 100);
            nameValidator.Next(urlValidator);

            var validator = new AddLinkCommandValidator(nameValidator);

            var valid = validator.Validate(addLinkCommand);

            Assert.True(valid);
        }

        [Test]
        public void AddLinkCommand_Invalid()
        {
            var addLinkCommand = new AddLinkCommand()
            {
                Name = "Google",
                Url = "invalid url"
            };
            var urlValidator = new UrlValidator();
            var nameValidator = new NameValidator(100);
            nameValidator.Next(urlValidator);

            var validator = new AddLinkCommandValidator(nameValidator);

            var valid = validator.Validate(addLinkCommand);

            Assert.False(valid);
        }
    }
}
