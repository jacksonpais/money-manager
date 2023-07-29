using money.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace money.core.Services.Interfaces
{
    public interface ITransactionTypeServiceAsync: IGenericServiceAsync<TransactionTypeMaster>
    {
        Task<List<TransactionTypeMaster>> GetAllAsync(Expression<Func<TransactionTypeMaster, bool>>? filter = null);
    }
}
