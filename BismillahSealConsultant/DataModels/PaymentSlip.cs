using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class PaymentSlip
    {
        public Guid Id { get; set; }
        public Guid? Payrollid { get; set; }
        public string? Note { get; set; }
        public double? Total { get; set; }
    }
}
