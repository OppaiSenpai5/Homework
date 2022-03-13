using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    public class GoldCard : DiscountCard
    {
        public override decimal DiscountRate
        {
            get
            {
                decimal initial = 0.02m;
                for (decimal i = PreviousMonthTurnover; i >= 100 && initial < 0.1m; i -= 100)
                {
                    initial += 0.01m;
                }
                return initial;
            }
        }

        public GoldCard(string owner, decimal turnover)
            : base(owner, turnover)
        {
        }
    }
}
