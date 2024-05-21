using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class ProjectEmployee
    {
        public Guid Id { get; set; }
        public Guid? ProjectId { get; set; }
        public Guid? EmployeeId { get; set; }
        public Guid? Rollid { get; set; }
        public DateTime? DateStarted { get; set; }
        public DateTime? DateEnded { get; set; }
        public bool? Iscurrent { get; set; }
    }
}
