using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    public class PayDesk
    {
        private PayDesk()
        {
        }

        public static void Output(decimal purchaseValue, DiscountCard card)
        {
            decimal discountRate = card.DiscountRate;
            decimal discount = purchaseValue * discountRate;
            decimal total = purchaseValue - discount;

            Console.WriteLine($"Purchase value: {purchaseValue:C2}");
            Console.WriteLine($"Discount rate: {discountRate:P1}");
            Console.WriteLine($"Discount: {discount:C2}");
            Console.WriteLine($"Total: {total:C2}");
        }
    }
}
