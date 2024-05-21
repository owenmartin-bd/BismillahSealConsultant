using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class Payment
    {
        public Guid Id { get; set; }
        public Guid? EmployeedId { get; set; }
        public Guid? PositionId { get; set; }
        public int? PaymentRefNumber { get; set; }
        public DateTime? Issuedate { get; set; }
        public string? Month { get; set; }
        public string? Year { get; set; }
    }
}
