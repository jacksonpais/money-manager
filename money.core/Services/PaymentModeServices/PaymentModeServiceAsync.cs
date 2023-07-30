using money.core.Services.Interfaces;
using money.domain.Entities;
using System.Linq.Expressions;
using money.infrastructure.Repositories.Interfaces;

namespace money.core.Services.PaymentModeServices
{
    public class PaymentModeServiceAsync : IPaymentModeServiceAsync
    {
        private readonly IPaymentModeRepositoryAsync _paymentModeRepository;
        public PaymentModeServiceAsync(IPaymentModeRepositoryAsync paymentModeRepository)
        {
            _paymentModeRepository = paymentModeRepository;
        }

        public async Task<List<PaymentModesMaster>> GetAllAsync(Expression<Func<PaymentModesMaster, bool>>? filter = null)
        {
            return await _paymentModeRepository.GetAllAsync(filter);
        }
    }
}