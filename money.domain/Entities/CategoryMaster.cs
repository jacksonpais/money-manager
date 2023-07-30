using money.domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money.domain.Entities
{
    public class CategoryMaster : AuditableBaseEntity
    {
        [Required]
        public string CategoryName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int TransactionTypeId { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string Icon { get; set; }
    }
}
