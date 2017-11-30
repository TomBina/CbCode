using System;
using System.Collections.Generic;
using System.Linq;

namespace CbCode.Examples.DesignPatterns.ChainOfResponsibilityFunctional
{
    public class Validator<T>
    {
        private readonly List<Func<T, bool>> _validators = new List<Func<T, bool>>();

        public Validator<T> Next(Func<T, bool> next)
        {
            _validators.Add(next);

            return this;
        }

        public bool Validate(T obj) 
            => _validators.All(validator => validator(obj));
    }
}