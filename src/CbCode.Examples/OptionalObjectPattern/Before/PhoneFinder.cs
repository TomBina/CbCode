using System.Collections.Generic;

namespace CbCode.Examples.OptionalObjectPattern.Before
{
    public class PhoneFinder
    {
        private readonly List<Phone> _phones = new List<Phone>()
        {
            new Phone(1, "Samsung Note 8", 999.95m),
            new Phone(2, "Samsung Galaxy S8", 899.95m)
        };

        public Phone Find(string name)
            => _phones.Find(p => p.Name == name);
    }
}