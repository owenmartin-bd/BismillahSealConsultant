using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class WorkerWorkingHour
    {
        public Guid Id { get; set; }
        public Guid? EmployeeId { get; set; }
        public DateOnly? Date { get; set; }
        public DateTime? InAm { get; set; }
        public DateTime? InPm { get; set; }
        public DateTime? OutAm { get; set; }
        public DateTime? OutPm { get; set; }
        public TimeSpan? WokingHours { get; set; }
        public TimeSpan? ExtraHour { get; set; }
        public TimeSpan? WorkingHoursRevised { get; set; }
        public DateTime? InAmRevise { get; set; }
        public DateTime? InPmRevise { get; set; }
        public DateTime? OutAmRevise { get; set; }
        public DateTime? OutPmRevise { get; set; }
        public string? Shift { get; set; }
        public string? Note { get; set; }
    }
}
