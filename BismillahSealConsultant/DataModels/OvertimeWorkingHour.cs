using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class OvertimeWorkingHour
    {
        public Guid OverTimeId { get; set; }
        public TimeSpan? StartAfter { get; set; }
        public TimeSpan? IcreamentCount { get; set; }
        public Guid? SchemaId { get; set; }
    }
}
