using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    public abstract class DiscountCard
    {
        public string Owner { get; set; }
        public decimal PreviousMonthTurnover { get; set; }
        abstract public decimal DiscountRate { get; }

        public DiscountCard(string owner, decimal turnover) =>
            (Owner, PreviousMonthTurnover) = (owner, turnover);
    }
}
