using CoinDispenser.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinDispenser.Context
{
    public class CoinDenominationContext
        : DbContext
    {
        public CoinDenominationContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<CoinDenomination> CoinDenominations { get; set; }
    }
}
