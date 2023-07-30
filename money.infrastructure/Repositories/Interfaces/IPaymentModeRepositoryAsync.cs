using money.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace money.infrastructure.Repositories.Interfaces
{
    public interface IPaymentModeRepositoryAsync : IGenericRepositoryAsync<PaymentModesMaster>
    {
        Task<List<PaymentModesMaster>> GetAllAsync(Expression<Func<PaymentModesMaster, bool>>? filter = null);
    }
}
