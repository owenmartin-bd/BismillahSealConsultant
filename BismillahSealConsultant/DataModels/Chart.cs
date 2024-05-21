using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class Chart
    {
        public Guid Id { get; set; }
        public DateTime? Intime { get; set; }
        public DateTime? Outtime { get; set; }
        public TimeSpan? Hour { get; set; }
        public Guid? ChartSchemaId { get; set; }
    }
}
