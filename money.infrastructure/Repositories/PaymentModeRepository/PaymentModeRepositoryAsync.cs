using Microsoft.EntityFrameworkCore;
using money.data.Context;
using money.domain.Entities;
using money.infrastructure.Repositories.GenericRepository;
using money.infrastructure.Repositories.Interfaces;
using System.Linq.Expressions;

namespace money.infrastructure.Repositories.PaymentModeRepositoryAsync
{
    public class PaymentModeRepositoryAsync : IPaymentModeRepositoryAsync
    {
        private readonly DataContext _db;
        internal DbSet<PaymentModesMaster> dbSet;
        public PaymentModeRepositoryAsync(DataContext db)
        {
            _db = db;
            dbSet = _db.Set<PaymentModesMaster>();
        }

        public async Task<List<PaymentModesMaster>> GetAllAsync(Expression<Func<PaymentModesMaster, bool>>? filter = null)
        {
            IQueryable<PaymentModesMaster> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.ToListAsync();
        }
    }
}
