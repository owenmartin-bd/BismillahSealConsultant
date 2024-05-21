using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class Payroll
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public double? Amount { get; set; }
        public double? Percentage { get; set; }
        public Guid? ReletedPayrollId { get; set; }
        public Guid? EmployeeId { get; set; }
        public Guid? SchemaId { get; set; }
    }
}
