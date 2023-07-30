using money.domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money.domain.Entities
{
    public class AccountTypeMaster : AuditableBaseEntity
    {
        [Required]
        public string AccountType { get; set; }
    }
}
