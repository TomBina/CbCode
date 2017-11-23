using System;

namespace CbCode.Examples.OptionalObjectPattern.After
{
    public static class Optional
    {
        private class SomeOption<T> : IOptional<T>
        {
            public bool HasValue { get; }
            private T Value { get; }

            public SomeOption(T value)
            {
                Value = value;
                HasValue = true;
            }

            public IOptional<T> WhenSome(Action<T> then)
            {
                then(Value);
                return this;
            }

            public IOptional<T> WhenNone(Action then)
                => this;

            public IOptional<T> When(Predicate<T> predicate)
                => predicate(Value) ? this : (IOptional<T>)new NoneOption<T>();

            public IOptional<TNew> Map<TNew>(Func<T, TNew> mapFunction)
                => new SomeOption<TNew>(mapFunction(Value));

            public T ValueOr(T or) => Value;
        }

        private class NoneOption<T> : IOptional<T>
        {
            public bool HasValue { get; }

            public IOptional<T> WhenSome(Action<T> then)
                => this;

            public IOptional<T> WhenNone(Action then)
            {
                then();
                return this;
            }

            public IOptional<T> When(Predicate<T> predicate)
                => this;

            public IOptional<TNew> Map<TNew>(Func<T, TNew> mapFunction)
                => new NoneOption<TNew>();

            public T ValueOr(T or) => or;
        }

        public static IOptional<T> Of<T>(T value)
            => value != null ? new SomeOption<T>(value) : (IOptional<T>)new NoneOption<T>();

        public static IOptional<T> Some<T>(T value)
            => new SomeOption<T>(value);

        public static IOptional<T> None<T>()
            => new NoneOption<T>();
    }
}