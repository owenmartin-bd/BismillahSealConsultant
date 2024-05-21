using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class Group
    {
        public Guid Id { get; set; }
        public string? GroupName { get; set; }
        public Guid? ProjectId { get; set; }
    }
}
