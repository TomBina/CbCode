namespace CbCode.Examples.DesignPatterns.StatePattern.After
{
    public class SmallDiscountPolicy : IDiscountPolicy
    {
        public IDiscountPolicy CalculateDiscount(Customer customer)
        {
            if (customer.Orders > 5)
                return new MediumDiscountPolicy().CalculateDiscount(customer);

            return this;
        }

        public decimal GetDiscount() => 0.1m;
    }
}