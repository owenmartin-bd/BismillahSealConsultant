using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class WorkingHoursCorrectionRequest
    {
        public Guid Id { get; set; }
        public DateOnly? Date { get; set; }
        public DateTime? Inam { get; set; }
        public DateTime? Outpm { get; set; }
        public DateTime? Active { get; set; }
        public Guid? EmployeeId { get; set; }
        public bool? Resolved { get; set; }
    }
}
