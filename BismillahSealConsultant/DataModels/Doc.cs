using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class Doc
    {
        public Guid Id { get; set; }
        public string? DocmentName { get; set; }
        public string? DocumentType { get; set; }
        public Guid? EmployeeId { get; set; }
        public string? Remark { get; set; }
        public string? Link { get; set; }

        public virtual Employee? Employee { get; set; }
    }
}
