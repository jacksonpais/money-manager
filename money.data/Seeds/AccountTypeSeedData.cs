using money.data.Seeds.Interfaces;
using money.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money.data.Seeds
{
    public class AccountTypeSeedData : ISeedData<AccountTypeMaster>
    {
        public List<AccountTypeMaster> AddSeedData()
        {
            return new List<AccountTypeMaster>()
            {
                new AccountTypeMaster
                {
                    Id = 1,
                    AccountType = "Bank Accounts",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                },
                new AccountTypeMaster
                {
                    Id = 2,
                    AccountType = "Credit Cards",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                },
                new AccountTypeMaster
                {
                    Id = 3,
                    AccountType = "Wallets",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                },
                new AccountTypeMaster
                {
                    Id = 4,
                    AccountType = "Cash",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                }
            };
        }
    }
}
