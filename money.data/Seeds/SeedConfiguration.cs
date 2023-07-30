using Microsoft.EntityFrameworkCore;
using money.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money.data.Seeds
{
    public static class SeedConfiguration
    {
        public static void AddSeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountTypeMaster>().HasData(new AccountTypeSeedData().AddSeedData());
            modelBuilder.Entity<CategoryMaster>().HasData(new CategorySeedData().AddSeedData());
            modelBuilder.Entity<CurrencyMaster>().HasData(new CurrencySeedData().AddSeedData());
            modelBuilder.Entity<PaymentModesMaster>().HasData(new PaymentModesSeedData().AddSeedData());
            modelBuilder.Entity<TransactionTypeMaster>().HasData(new TransactionTypeSeedData().AddSeedData());
        }
    }
}
