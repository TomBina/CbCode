namespace CbCode.Examples.DesignPatterns.StatePattern.After
{
    public interface IDiscountPolicy
    {
        IDiscountPolicy CalculateDiscount(Customer customer);
        decimal GetDiscount();
    }
}