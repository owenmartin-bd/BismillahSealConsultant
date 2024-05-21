using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class EmployeeWithLatestRate
    {
        public Guid? EmployeeId { get; set; }
        public double? LatestRate { get; set; }
        public DateTime? RateEffectiveDate { get; set; }
    }
}
