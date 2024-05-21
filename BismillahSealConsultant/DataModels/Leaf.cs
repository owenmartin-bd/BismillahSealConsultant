using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class Leaf
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public string? Reason { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Type { get; set; } = null!;
    }
}
