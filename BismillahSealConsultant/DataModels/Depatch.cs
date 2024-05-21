using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class Depatch
    {
        public Guid Id { get; set; }
        public Guid? EmplyeeId { get; set; }
        public DateOnly? Month { get; set; }
        public double? TotalAmount { get; set; }
        public double? PreviousBalance { get; set; }
        public double? ActualAmount { get; set; }
        public double? CompanyCost { get; set; }
        public double? RemainingAmount { get; set; }
    }
}
