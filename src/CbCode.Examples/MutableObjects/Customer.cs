using System;

namespace CbCode.Examples.MutableObjects
{
    public class Customer
    {
        public decimal Wallet { get; set; } = 100m;
        private decimal _moneySpent;

        public void PlaceInCart(Product product)
        {
            if (Wallet < product.Price)
                throw new InvalidOperationException("Not enough money");

            _moneySpent += product.Price;
            
            // Other logic..
        }

        public void CheckOut()
        {
            Wallet -= _moneySpent;
        }
    }
}