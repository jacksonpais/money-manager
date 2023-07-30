using money.core.Services.Interfaces;
using money.domain.Entities;
using System.Linq.Expressions;
using money.infrastructure.Repositories.Interfaces;

namespace money.core.Services.AccountTypeServices
{
    public class AccountTypeServiceAsync : IAccountTypeServiceAsync
    {
        private readonly IAccountTypeRepositoryAsync _accountTypeRepository;
        public AccountTypeServiceAsync(IAccountTypeRepositoryAsync accountTypeRepository)
        {
            _accountTypeRepository = accountTypeRepository;
        }

        public async Task<List<AccountTypeMaster>> GetAllAsync(Expression<Func<AccountTypeMaster, bool>>? filter = null)
        {
            return await _accountTypeRepository.GetAllAsync(filter);
        }
    }
}