using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    public class BronzeCard : DiscountCard
    {
        public override decimal DiscountRate
        {
            get
            {
                if (PreviousMonthTurnover < 100)
                    return 0;
                if (PreviousMonthTurnover <= 300)
                    return 0.01m;
                return 0.025m;
            }
        }

        public BronzeCard(string owner, decimal turnover)
            : base(owner, turnover)
        {
        }
    }
}
