using System;

namespace CbCode.Examples.DesignPatterns.StatePattern.After
{
    public class Customer
    {
        public int Orders { get; private set; }
        public DateTime LastOrderDate { get; private set; }

        private IDiscountPolicy _discountPolicy;

        public Customer(int orders, DateTime lastOrderDate)
        {
            Orders = orders;
            LastOrderDate = lastOrderDate;
            
            _discountPolicy = new NoDiscountPolicy();
            ReCalculateDiscount();
        }

        public void PlacedOrder()
        {
            Orders++;
            LastOrderDate = DateTime.Now;
            ReCalculateDiscount();
        }

        private void ReCalculateDiscount() 
            => _discountPolicy = _discountPolicy.CalculateDiscount(this);

        public decimal GetDiscount()
            => _discountPolicy.GetDiscount();
    }
}