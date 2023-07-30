using money.domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money.core.Features.AccountType.Queries.GetAllAccountTypes
{
    public class AllAccountTypesViewModel
    {
        public int Id { get; set; }

        public string AccountType { get; set; }
    }
}
