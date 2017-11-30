using System;

namespace CbCode.Examples.DesignPatterns.OptionalObjectPattern.After
{
    public interface IOptional<T>
    {
        bool HasValue { get; }

        IOptional<T> WhenSome(Action<T> then);
        IOptional<T> WhenNone(Action then);
        IOptional<T> When(Predicate<T> predicate);
        IOptional<TNew> Map<TNew>(Func<T, TNew> mapFunction);
        T ValueOr(T or);
    }
}