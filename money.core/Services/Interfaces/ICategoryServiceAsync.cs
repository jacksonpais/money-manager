using money.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace money.core.Services.Interfaces
{
    public interface ICategoryServiceAsync: IGenericServiceAsync<CategoryMaster>
    {
        Task<List<CategoryMaster>> GetAllAsync(Expression<Func<CategoryMaster, bool>>? filter = null);
    }
}
