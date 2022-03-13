using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    public class SilverCard : DiscountCard
    {
        public override decimal DiscountRate
        {
            get
            {
                if (PreviousMonthTurnover > 300)
                    return 0.035m;
                return 0.02m;
            }
        }

        public SilverCard(string owner, decimal turnover)
            : base(owner, turnover)
        {
        }
    }
}
