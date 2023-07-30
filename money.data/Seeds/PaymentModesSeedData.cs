using money.data.Seeds.Interfaces;
using money.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money.data.Seeds
{
    public class PaymentModesSeedData : ISeedData<PaymentModesMaster>
    {
        public List<PaymentModesMaster> AddSeedData()
        {
            return new List<PaymentModesMaster>()
            {
                new PaymentModesMaster
                {
                    Id = 1,
                    PaymentModes = "Debit Card",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new PaymentModesMaster
                {
                    Id = 2,
                    PaymentModes = "UPI",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new PaymentModesMaster
                {
                    Id = 3,
                    PaymentModes = "Cheque",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new PaymentModesMaster
                {
                    Id = 4,
                    PaymentModes = "Internet Banking",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                }
            };
        }
    }
}
