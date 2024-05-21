using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class PaySlipField
    {
        public Guid Id { get; set; }
        public double? Amount { get; set; }
        public DateTime? Date { get; set; }
        public string? Name { get; set; }
        public Guid? RollId { get; set; }
        public Guid? EmployeeId { get; set; }
    }
}
