using Microsoft.EntityFrameworkCore;
using money.data.Context;
using money.domain.Entities;
using money.infrastructure.Repositories.GenericRepository;
using money.infrastructure.Repositories.Interfaces;
using System.Linq.Expressions;

namespace money.infrastructure.Repositories.CategoryRepositoryAsync
{
    public class CategoryRepositoryAsync : ICategoryRepositoryAsync
    {
        private readonly DataContext _db;
        internal DbSet<CategoryMaster> dbSet;
        public CategoryRepositoryAsync(DataContext db)
        {
            _db = db;
            dbSet = _db.Set<CategoryMaster>();
        }

        public async Task<List<CategoryMaster>> GetAllAsync(Expression<Func<CategoryMaster, bool>>? filter = null)
        {
            IQueryable<CategoryMaster> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.ToListAsync();
        }
    }
}
