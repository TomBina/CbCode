using System;

namespace CbCode.Examples.ChainOfResponsibilityFunctional
{
    public class AddLinkCommandValidator : Validator<AddLinkCommand>
    {
        public AddLinkCommandValidator()
        {
            this.NotNull(c => c.Name)
                .Must(c => c.Name.Length > 0)
                .Must(c => Uri.IsWellFormedUriString(c.Url, UriKind.Absolute));
        }
    }
}