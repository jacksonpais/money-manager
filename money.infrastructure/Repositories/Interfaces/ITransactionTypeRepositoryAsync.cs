using money.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace money.infrastructure.Repositories.Interfaces
{
    public interface ITransactionTypeRepositoryAsync : IGenericRepositoryAsync<TransactionTypeMaster>
    {
        Task<List<TransactionTypeMaster>> GetAllAsync(Expression<Func<TransactionTypeMaster, bool>>? filter = null);
    }
}
