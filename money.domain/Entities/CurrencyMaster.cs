using money.domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money.domain.Entities
{
    public class CurrencyMaster : AuditableBaseEntity
    {
        [Required]
        public string CurrencyName { get; set; }

        [Required]
        public string CurrencyCode { get; set; }

        [Required]
        public bool DefaultCurrency { get; set; }
    }
}
