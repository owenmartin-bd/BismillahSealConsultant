using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class TeamEmployee
    {
        public Guid Id { get; set; }
        public Guid? TeamId { get; set; }
        public Guid? EmployeeId { get; set; }
    }
}
