using money.core.Services.Interfaces;
using money.domain.Entities;
using System.Linq.Expressions;
using money.infrastructure.Repositories.Interfaces;

namespace money.core.Services.CategoryServices
{
    public class CategoryServiceAsync : ICategoryServiceAsync
    {
        private readonly ICategoryRepositoryAsync _categoryRepository;
        public CategoryServiceAsync(ICategoryRepositoryAsync categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<List<CategoryMaster>> GetAllAsync(Expression<Func<CategoryMaster, bool>>? filter = null)
        {
            return await _categoryRepository.GetAllAsync(filter);
        }
    }
}