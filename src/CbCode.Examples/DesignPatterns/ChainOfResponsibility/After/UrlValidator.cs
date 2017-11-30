using System;

namespace CbCode.Examples.DesignPatterns.ChainOfResponsibility.After
{
    public class UrlValidator : IValidator<AddLinkCommand>
    {
        private IValidator<AddLinkCommand> _next;

        public bool IsValid(AddLinkCommand command)
        {
            if (Uri.IsWellFormedUriString(command.Url, UriKind.Absolute))
                return _next?.IsValid(command) ?? true;

            return false;
        }

        public IValidator<AddLinkCommand> Next(IValidator<AddLinkCommand> next)
        {
            _next = next;

            return next;
        }
    }
}