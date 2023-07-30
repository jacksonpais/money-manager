using Microsoft.EntityFrameworkCore;
using money.data.Context;
using money.domain.Entities;
using money.infrastructure.Repositories.GenericRepository;
using money.infrastructure.Repositories.Interfaces;
using System.Linq.Expressions;

namespace money.infrastructure.Repositories.AccountTypeRepository
{
    public class AccountTypeRepositoryAsync : IAccountTypeRepositoryAsync
    {
        private readonly DataContext _db;
        internal DbSet<AccountTypeMaster> dbSet;
        public AccountTypeRepositoryAsync(DataContext db)
        {
            _db = db;
            dbSet = _db.Set<AccountTypeMaster>();
        }

        public async Task<List<AccountTypeMaster>> GetAllAsync(Expression<Func<AccountTypeMaster, bool>>? filter = null)
        {
            IQueryable<AccountTypeMaster> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.ToListAsync();
        }
    }
}
