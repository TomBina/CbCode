using System;

namespace CbCode.Examples.StatePattern.After
{
    public class Customer
    {
        public int Orders { get; private set; }
        public DateTime LastOrderDate { get; private set; }
        public IDiscountPolicy DiscountPolicy { get; private set; }

        public Customer(int orders, DateTime lastOrderDate)
        {
            Orders = orders;
            LastOrderDate = lastOrderDate;
            
            DiscountPolicy = new NoDiscountPolicy();
            ReCalculateDiscount();
        }

        public void PlacedOrder()
        {
            Orders++;
            LastOrderDate = DateTime.Now;
            ReCalculateDiscount();
        }

        private void ReCalculateDiscount()
        {
            DiscountPolicy = DiscountPolicy.CalculateDiscount(this);
        }
    }
}