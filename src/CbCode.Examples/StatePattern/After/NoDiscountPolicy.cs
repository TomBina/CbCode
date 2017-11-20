using System;

namespace CbCode.Examples.StatePattern.After
{
    public class NoDiscountPolicy : IDiscountPolicy
    {
        public IDiscountPolicy CalculateDiscount(Customer customer)
        {
            if (customer.Orders > 0 && (DateTime.Now - customer.LastOrderDate).Days < 10)
                return new SmallDiscountPolicy().CalculateDiscount(customer);

            return this;
        }

        public decimal GetDiscount() => 0m;
    }
}