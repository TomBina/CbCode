using System;
using System.Collections.Generic;
using CbCode.Examples.StrategyPatternWithFunc;
using NUnit.Framework;

namespace CbCode.Tests.StrategyPatternWithFunc
{
    public class Tests
    {
        [Test]
        public void SoldProduct_NotDamaged_CanClaimMoneyBack()
        {
            var rules = new List<Func<SoldProduct, bool>>()
            {
                product => (DateTime.Now - product.Sold).TotalDays < 30,
                product => !product.Damaged
            };
            var soldProduct = new SoldProduct(1, "Some product", DateTime.Now, rules);
            
            var canClaimMoneyBack = soldProduct.CanClaimMoneyBack();

            Assert.IsTrue(canClaimMoneyBack);
        }

        [Test]
        public void SoldProduct_Damaged_CannotClaimMoneyBack()
        {
            var rules = new List<Func<SoldProduct, bool>>()
            {
                product => (DateTime.Now - product.Sold).TotalDays < 30,
                product => !product.Damaged
            };
            var soldProduct = new SoldProduct(1, "Some product", DateTime.Now, rules);
            soldProduct.MarkDamaged();

            var canClaimMoneyBack = soldProduct.CanClaimMoneyBack();

            Assert.IsFalse(canClaimMoneyBack);
        }
    }
}
