using money.core.Services.Interfaces;
using money.domain.Entities;
using System.Linq.Expressions;
using money.infrastructure.Repositories.Interfaces;

namespace money.core.Services.CurrencyServices
{
    public class CurrencyServiceAsync : ICurrencyServiceAsync
    {
        private readonly ICurrencyRepositoryAsync _currencyRepository;
        public CurrencyServiceAsync(ICurrencyRepositoryAsync currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public async Task<List<CurrencyMaster>> GetAllAsync(Expression<Func<CurrencyMaster, bool>>? filter = null)
        {
            return await _currencyRepository.GetAllAsync(filter);
        }
    }
}