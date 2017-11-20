namespace CbCode.Examples.StatePattern.After
{
    public interface IDiscountPolicy
    {
        IDiscountPolicy CalculateDiscount(Customer customer);
        decimal GetDiscount();
    }
}