using money.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace money.core.Services.Interfaces
{
    public interface IAccountTypeServiceAsync: IGenericServiceAsync<AccountTypeMaster>
    {
        Task<List<AccountTypeMaster>> GetAllAsync(Expression<Func<AccountTypeMaster, bool>>? filter = null);
    }
}
