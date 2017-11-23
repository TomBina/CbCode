using System.Collections.Generic;

namespace CbCode.Examples.OptionalObjectPattern.After
{
    public class PhoneFinder
    {
        private readonly List<Phone> _phones = new List<Phone>()
        {
            new Phone("Samsung Note 8", 999.95m),
            new Phone("Samsung Galaxy S8", 899.95m)
        };

        public IOptional<Phone> Find(string name)
            => Optional.Of(_phones.Find(p => p.Name == name));
    }
}