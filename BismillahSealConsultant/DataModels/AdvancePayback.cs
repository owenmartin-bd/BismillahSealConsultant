using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class AdvancePayback
    {
        public Guid Id { get; set; }
        public Guid? EmployeeId { get; set; }
        public DateOnly? Date { get; set; }
        public double? Amount { get; set; }
    }
}
