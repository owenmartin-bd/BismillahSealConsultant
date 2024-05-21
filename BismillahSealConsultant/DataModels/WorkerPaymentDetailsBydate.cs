using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class WorkerPaymentDetailsBydate
    {
        public Guid Id { get; set; }
        public Guid? EmployeeId { get; set; }
        public DateOnly? Date { get; set; }
        public DateTime? IntimeActual { get; set; }
        public DateTime? OutTimeActual { get; set; }
        public DateTime? InTime { get; set; }
        public DateTime? OutTime { get; set; }
        public TimeSpan? BreakTime { get; set; }
        public TimeSpan? OverTime { get; set; }
        public TimeSpan? ActualHours { get; set; }
        public TimeSpan? OtExtraHours { get; set; }
        public TimeSpan? TotalHours { get; set; }
        public decimal? RatePerHour { get; set; }
        public decimal? TotalEarnedOnDate { get; set; }
        public TimeSpan? OnSite { get; set; }
        public bool Paid { get; set; }
        public DateOnly? Paidate { get; set; }
        public Guid? SchemaId { get; set; }
    }
}
