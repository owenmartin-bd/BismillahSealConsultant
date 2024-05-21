using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class Deduction
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public double? Amount { get; set; }
        public double? Percentage { get; set; }
        public Guid? ReferencePaymentId { get; set; }
        public string? Type { get; set; }
        public Guid? Employeeid { get; set; }
        public Guid? SchemaId { get; set; }
    }
}
