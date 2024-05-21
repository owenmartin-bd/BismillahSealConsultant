using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class ExitTime
    {
        public Guid Id { get; set; }
        public TimeOnly? StartTine { get; set; }
        public TimeOnly? EndTime { get; set; }
        public TimeOnly? TakenTime { get; set; }
        public Guid? SchemaId { get; set; }
    }
}
