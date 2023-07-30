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
            // TransactionTypeMaster
            modelBuilder.Entity<TransactionTypeMaster>().HasData(new TransactionTypeSeedData().AddSeedData());
        }
    }
}
