using System;

namespace CbCode.Examples.StatePattern.Before
{
    public class Customer
    {
        public int Orders { get; private set; }
        public DateTime LastOrderDate { get; private set; }
        public decimal Discount { get; private set; }

        public Customer(int orders, DateTime lastOrderDate)
        {
            Orders = orders;
            LastOrderDate = lastOrderDate;
        }

        public void PlacedOrder()
        {
            Orders++;
            LastOrderDate = DateTime.Now;
        }

        public decimal GetDiscount()
        {

            if (Orders > 0 && Orders <= 5 && (DateTime.Now - LastOrderDate).Days < 10)
            {
                return 0.1m;
            }
            else if (Orders > 5 && Orders <= 10 && (DateTime.Now - LastOrderDate).Days < 10)
            {
                return 0.2m;
            }
            else if (Orders > 10 && (DateTime.Now - LastOrderDate).Days < 10)
            {
                return 0.3m;
            }
            else
            {
                return 0m;
            }
        }
    }
}