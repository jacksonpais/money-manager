using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money.domain.Common
{
    public abstract class UserBaseEntity : AuditableBaseEntity
    {
        public int UserId { get; set; }
    }
}
