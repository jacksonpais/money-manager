using money.data.Seeds.Interfaces;
using money.domain.Entities;

namespace money.data.Seeds
{
    public class TransactionTypeSeedData : ISeedData<TransactionTypeMaster>
    {
        public List<TransactionTypeMaster> AddSeedData()
        {
            return new List<TransactionTypeMaster>()
            {
                new TransactionTypeMaster
                {
                    Id = 1,
                    TrasactionType = "Income",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new TransactionTypeMaster
                {
                    Id = 2,
                    TrasactionType = "Expensencome",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new TransactionTypeMaster
                {
                    Id = 3,
                    TrasactionType = "Transfer",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                }};
        }
    }
}
