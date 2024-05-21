using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class ViewDispacfield
    {
        public Guid? FieldId { get; set; }
        public Guid? EmplyeeId { get; set; }
        public DateOnly? Month { get; set; }
        public string? Name { get; set; }
        public double? Amount { get; set; }
        public bool? Isearning { get; set; }
    }
}
