using money.domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money.core.Features.PaymentMode.Queries.GetAllPaymentModes
{
    public class AllPaymentModeViewModel
    {
        public int Id { get; set; }

        public string TrasactionType { get; set; }
    }
}
