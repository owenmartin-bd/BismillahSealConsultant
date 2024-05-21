using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class Degree
    {
        public Guid Id { get; set; }
        public Guid Employeeid { get; set; }
        public string DegreeName { get; set; } = null!;
        public string GradeResult { get; set; } = null!;
        public string PassingYear { get; set; } = null!;
        public string? Remark { get; set; }

        public virtual Employee Employee { get; set; } = null!;
    }
}
