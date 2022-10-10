using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinDispenser.Context
{
    using CoinDispenser.Models;
    using System.Linq;

    public static class InitialData
    {
        public static void Seed(this CoinDenominationContext dbContext)
        {
            if (!dbContext.CoinDenominations.Any())
            {
                dbContext.CoinDenominations.Add(new CoinDenomination
                {
                    V1 = 1,
                    V2 = 2,
                    V3 = 5,
                    V4 = 10,
                    V5 = 20,
                    V6 = 50,
                    V7 = 100,
                    V8 = 200,
                    V9 = 500
                });

                dbContext.SaveChanges();
            }
        }
    }
}
