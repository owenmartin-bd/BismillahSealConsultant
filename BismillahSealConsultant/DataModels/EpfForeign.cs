using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class EpfForeign
    {
        public Guid Id { get; set; }
        public double? From { get; set; }
        public double? To { get; set; }
        public double? ByTheEnployeer { get; set; }
        public double? ByTheEmployee { get; set; }
        public double? Total { get; set; }
    }
}
