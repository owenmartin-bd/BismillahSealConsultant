using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class Payrolldeductionschema
    {
        public Guid Id { get; set; }
        public DateOnly? SinceDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public Guid? EmployeeId { get; set; }
    }
}
