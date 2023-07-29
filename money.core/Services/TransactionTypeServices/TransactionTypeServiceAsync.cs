using money.core.Services.Interfaces;
using money.domain.Entities;
using System.Linq.Expressions;
using money.infrastructure.Repositories.Interfaces;

namespace money.core.Services.TransactionTypeServices
{
    public class TransactionTypeServiceAsync : ITransactionTypeServiceAsync
    {
        private readonly ITransactionTypeRepositoryAsync _transactionTypeRepository;
        public TransactionTypeServiceAsync(ITransactionTypeRepositoryAsync transactionTypeRepository)
        {
            _transactionTypeRepository = transactionTypeRepository;
        }

        public async Task<List<TransactionTypeMaster>> GetAllAsync(Expression<Func<TransactionTypeMaster, bool>>? filter = null)
        {
            return await _transactionTypeRepository.GetAllAsync(filter);
        }
    }
}