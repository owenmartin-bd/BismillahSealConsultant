using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class HourRule
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public bool? Active { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
