namespace CbCode.Examples.DesignPatterns.StatePattern.After
{
    public class MediumDiscountPolicy : IDiscountPolicy
    {
        public IDiscountPolicy CalculateDiscount(Customer customer)
        {
            if (customer.Orders > 10)
                return new LargeDiscountPolicy().CalculateDiscount(customer);

            return this;
        }

        public decimal GetDiscount() => 0.2m;
    }
}