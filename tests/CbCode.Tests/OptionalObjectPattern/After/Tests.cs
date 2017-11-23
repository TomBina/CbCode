using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CbCode.Examples.OptionalObjectPattern.After;
using NUnit.Framework;

namespace CbCode.Tests.OptionalObjectPattern.After
{
    public class Tests
    {
        [TestCase(1000, "Samsung Galaxy S8", ExpectedResult = true)]
        [TestCase(500, "Samsung Galaxy S8", ExpectedResult = false)]
        [TestCase(1000, "Phone that doesn't exist", ExpectedResult = false)]
        public bool PhoneViewModel_HasValue(decimal budget, string query)
        {
            var phoneFinder = new PhoneFinder();
            var phone = phoneFinder.Find(query);

            var viewmodel = phone.When(p => p.Price < budget)
                                 .Map(p => new PhoneViewModel()
                                 {
                                     Name = p.Name,
                                     Price = p.Price
                                 });

            return viewmodel.HasValue;
        }
    }
}
