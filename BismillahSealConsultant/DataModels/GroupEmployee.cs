using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class GroupEmployee
    {
        public Guid Id { get; set; }
        public Guid? GroupId { get; set; }
        public Guid? EmployeId { get; set; }
    }
}
