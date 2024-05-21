using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class EmployeeLogView
    {
        public Guid? LogId { get; set; }
        public string? Item { get; set; }
        public DateTime? DateTime { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmployeeCode { get; set; }
        public Guid? RollId { get; set; }
        public string? Level { get; set; }
    }
}
