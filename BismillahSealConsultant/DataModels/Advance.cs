using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class Advance
    {
        public Guid Id { get; set; }
        public DateOnly? RequestedDate { get; set; }
        public DateOnly? ApprovalDate { get; set; }
        public Guid? RequestBy { get; set; }
        public Guid? ApprovedBy { get; set; }
        public double? RequestAmount { get; set; }
        public bool? Approved { get; set; }
        public bool? Requested { get; set; }
        public bool? Detchpatched { get; set; }
        public Guid? EmployeeId { get; set; }
        public DateOnly? DeatchpathedDate { get; set; }
        public double? DetchpatchedAmount { get; set; }
    }
}
