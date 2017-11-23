using CbCode.Examples.OptionalObjectPattern.Before;
using NUnit.Framework;

namespace CbCode.Tests.OptionalObjectPattern.Before
{
    public class Tests
    {
        [TestCase(1000, "Samsung Galaxy S8", ExpectedResult = true)]
        [TestCase(500, "Samsung Galaxy S8", ExpectedResult = false)]
        [TestCase(1000, "Phone that doesn't exist", ExpectedResult = false)]
        public bool PhotoViewModel_IsNotNull(decimal budget, string query)
        {
            var phoneFinder = new PhoneFinder();
            var phone = phoneFinder.Find(query);

            PhoneViewModel viewModel = null;

            if (phone?.Price < budget)
            {
                viewModel = new PhoneViewModel()
                {
                    Name = phone.Name,
                    Price = phone.Price
                };
            }

            return viewModel != null;
        }
    }
}