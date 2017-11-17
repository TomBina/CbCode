namespace CbCode.Examples.ChainOfResponsibility.After
{
    public class NameValidator : IValidator<AddLinkCommand>
    {
        private readonly int _maxLength;
        private IValidator<AddLinkCommand> _next;

        public NameValidator(int maxLength)
        {
            _maxLength = maxLength;
        }

        public bool IsValid(AddLinkCommand command)
        {
            if (!string.IsNullOrEmpty(command.Name) && command.Name.Length <= _maxLength)
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