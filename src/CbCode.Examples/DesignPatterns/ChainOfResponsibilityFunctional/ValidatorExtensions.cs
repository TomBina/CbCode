using System;

namespace CbCode.Examples.DesignPatterns.ChainOfResponsibilityFunctional
{
    public static class ValidatorExtensions
    {
        public static Validator<T> Must<T>(this Validator<T> validator, Func<T, bool> predicate)
            => validator.Next(predicate);

        public static Validator<T> NotNull<T, TProperty>(this Validator<T> validator, Func<T, TProperty> member) 
            => validator.Next(obj => member(obj) != null);
    }
}