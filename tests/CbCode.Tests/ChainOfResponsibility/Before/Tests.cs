using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CbCode.Examples.ChainOfResponsibility.Before;
using NUnit.Framework;

namespace CbCode.Tests.ChainOfResponsibility.Before
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

            Link link = null;

            if (!string.IsNullOrEmpty(addLinkCommand.Name) && addLinkCommand.Name.Length < 100)
            {
                if (Uri.IsWellFormedUriString(addLinkCommand.Url, UriKind.Absolute))
                {
                    link = new Link(addLinkCommand.Name, addLinkCommand.Url);
                }
            }

            Assert.NotNull(link);
        }
    }
}