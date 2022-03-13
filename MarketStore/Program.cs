using System;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            BronzeCard bronze = new BronzeCard("Bob", 0);
            PayDesk.Output(150, bronze);
            SilverCard silver = new SilverCard("Bob", 600);
            PayDesk.Output(850, silver);
            GoldCard gold = new GoldCard("Bob", 1500);
            PayDesk.Output(1300, gold);
        }
    }
}
