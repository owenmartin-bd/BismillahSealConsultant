using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class Extradeduction
    {
        public Guid Id { get; set; }
        public double? Levy { get; set; }
        public double? ProbashDeposit { get; set; }
        public double? ProbashLoan { get; set; }
        public double? OfficeAdvance { get; set; }
        public double? SiteAdvance { get; set; }
        public double? PreviousLoan { get; set; }
        public double? Ppe { get; set; }
        public double? Others { get; set; }
        public string? RmarkOthers { get; set; }
        public Guid? EmployeeId { get; set; }
        public DateOnly? Date { get; set; }
        public double? Penalty { get; set; }
        public bool? Epf { get; set; }
        public bool? Sosco { get; set; }
    }
}
