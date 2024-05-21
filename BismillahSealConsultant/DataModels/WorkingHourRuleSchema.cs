using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class WorkingHourRuleSchema
    {
        public Guid SchemaId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? RuleName { get; set; }
    }
}
