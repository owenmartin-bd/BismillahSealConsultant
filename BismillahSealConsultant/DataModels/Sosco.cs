using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class Sosco
    {
        public Guid Id { get; set; }
        public double? From { get; set; }
        public double? To { get; set; }
        public double? EmployersContribution { get; set; }
        public double? EmployeeContribution { get; set; }
        public double? Total { get; set; }
    }
}
