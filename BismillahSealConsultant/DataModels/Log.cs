using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class Log
    {
        public Guid Id { get; set; }
        public string? Item { get; set; }
        public DateTime? DateTime { get; set; }
        public Guid? EmpId { get; set; }
    }
}
