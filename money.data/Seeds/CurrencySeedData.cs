using money.data.Seeds.Interfaces;
using money.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money.data.Seeds
{
    public class CurrencySeedData : ISeedData<CurrencyMaster>
    {
        public List<CurrencyMaster> AddSeedData()
        {
            return new List<CurrencyMaster>()
            {
                new CurrencyMaster
                {
                    Id = 1,
                    CurrencyCode = "INR",
                    CurrencyName = "Rupee",
                    DefaultCurrency = true,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new CurrencyMaster
                {
                    Id = 2,
                    CurrencyCode = "USD",
                    CurrencyName = "Dollar",
                    DefaultCurrency = false,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new CurrencyMaster
                {
                    Id = 3,
                    CurrencyCode = "GBP",
                    CurrencyName = "Pound",
                    DefaultCurrency = false,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new CurrencyMaster
                {
                    Id = 4,
                    CurrencyCode = "EUR",
                    CurrencyName = "Euro",
                    DefaultCurrency = false,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                }};
        }
    }
}
