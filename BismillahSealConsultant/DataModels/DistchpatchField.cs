using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class DistchpatchField
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public Guid? DitchpathId { get; set; }
        public double? Amount { get; set; }
        public bool? Isearning { get; set; }
    }
}
