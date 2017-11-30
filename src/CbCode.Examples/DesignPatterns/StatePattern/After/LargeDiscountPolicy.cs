namespace CbCode.Examples.DesignPatterns.StatePattern.After
{
    public class LargeDiscountPolicy : IDiscountPolicy
    {
        public IDiscountPolicy CalculateDiscount(Customer customer)
            => this;

        public decimal GetDiscount() => 0.3m;
    }
}