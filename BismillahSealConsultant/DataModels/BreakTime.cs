using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class BreakTime
    {
        public Guid BreakTimeId { get; set; }
        public TimeOnly? StartTime { get; set; }
        public TimeOnly? EndTime { get; set; }
        public Guid? SchemaId { get; set; }
    }
}
