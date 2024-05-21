using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class ProjectTeam
    {
        public Guid TeamId { get; set; }
        public Guid? ProjectId { get; set; }
        public string? TeamName { get; set; }
        public string? TeamPurpose { get; set; }
        public Guid? GroupId { get; set; }
    }
}
