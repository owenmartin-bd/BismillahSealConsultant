using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class PamentSchema
    {
        public Guid Id { get; set; }
        public string? SchemaName { get; set; }
        public DateOnly? DateCreate { get; set; }
    }
}
