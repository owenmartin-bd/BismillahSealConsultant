using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class AppLog
    {
        public Guid Id { get; set; }
        public Guid? Employeeid { get; set; }
        public DateTime? Datetime { get; set; }
    }
}
