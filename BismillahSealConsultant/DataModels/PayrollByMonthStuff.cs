using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class PayrollByMonthStuff
    {
        public Guid Id { get; set; }
        public Guid? EmployeeId { get; set; }
        public double? Amount { get; set; }
        public bool? Earning { get; set; }
        public DateOnly? Month { get; set; }
        public string? FieldName { get; set; }
    }
}
