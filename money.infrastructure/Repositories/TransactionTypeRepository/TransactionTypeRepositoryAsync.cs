using Microsoft.EntityFrameworkCore;
using money.data.Context;
using money.domain.Entities;
using money.infrastructure.Repositories.GenericRepository;
using money.infrastructure.Repositories.Interfaces;
using System.Linq.Expressions;

namespace money.infrastructure.Repositories.TransactionTypeRepository
{
    public class TransactionTypeRepositoryAsync : ITransactionTypeRepositoryAsync
    {
        private readonly DataContext _db;
        internal DbSet<TransactionTypeMaster> dbSet;
        public TransactionTypeRepositoryAsync(DataContext db)
        {
            _db = db;
            dbSet = _db.Set<TransactionTypeMaster>();
        }

        public async Task<List<TransactionTypeMaster>> GetAllAsync(Expression<Func<TransactionTypeMaster, bool>>? filter = null)
        {
            IQueryable<TransactionTypeMaster> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.ToListAsync();
        }
    }
}
