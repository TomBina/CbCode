using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CbCode.Examples.StrategyPatternWithFunc
{
    public class SoldProduct
    {
        public int Id { get; }
        public string Name { get; }
        public DateTime Sold { get; }
        public bool Damaged { get; private set; }
        public IEnumerable<Func<SoldProduct, bool>> MoneyBackRules { get; }

        public SoldProduct(int id, string name, DateTime sold, IEnumerable<Func<SoldProduct, bool>> moneyBackRules)
        {
            Id = id;
            Name = name;
            Sold = sold;
            MoneyBackRules = moneyBackRules;
        }

        public void MarkDamaged()
            => Damaged = true;

        public bool CanClaimMoneyBack() 
            => MoneyBackRules.All(r => r(this));
    }
}
