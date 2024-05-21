using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class WorkerHourlyRate
    {
        public Guid Id { get; set; }
        public Guid? EmployeeId { get; set; }
        public double? Rate { get; set; }
        public DateTime? SinceDate { get; set; }
    }
}
