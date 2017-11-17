namespace CbCode.Examples.ChainOfResponsibility.After
{
    public interface IValidator<T>
    {
        bool IsValid(T command);
        IValidator<T> Next(IValidator<T> next);
    }
}