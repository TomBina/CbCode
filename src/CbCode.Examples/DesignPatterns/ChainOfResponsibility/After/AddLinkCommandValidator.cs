namespace CbCode.Examples.DesignPatterns.ChainOfResponsibility.After
{
    public class AddLinkCommandValidator
    {
        private readonly IValidator<AddLinkCommand> _validator;

        public AddLinkCommandValidator(IValidator<AddLinkCommand> validator)
        {
            _validator = validator;
        }

        public bool Validate(AddLinkCommand command)
            => _validator.IsValid(command);
    }
}