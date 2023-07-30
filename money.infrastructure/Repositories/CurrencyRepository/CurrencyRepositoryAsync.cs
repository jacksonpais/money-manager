using Microsoft.EntityFrameworkCore;
using money.data.Context;
using money.domain.Entities;
using money.infrastructure.Repositories.GenericRepository;
using money.infrastructure.Repositories.Interfaces;
using System.Linq.Expressions;

namespace money.infrastructure.Repositories.CurrencyRepositoryAsync
{
    public class CurrencyRepositoryAsync : ICurrencyRepositoryAsync
    {
        private readonly DataContext _db;
        internal DbSet<CurrencyMaster> dbSet;
        public CurrencyRepositoryAsync(DataContext db)
        {
            _db = db;
            dbSet = _db.Set<CurrencyMaster>();
        }

        public async Task<List<CurrencyMaster>> GetAllAsync(Expression<Func<CurrencyMaster, bool>>? filter = null)
        {
            IQueryable<CurrencyMaster> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.ToListAsync();
        }
    }
}
