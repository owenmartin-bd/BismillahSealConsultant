using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class Project
    {
        public Guid Id { get; set; }
        public string? ProjectName { get; set; }
        public string? Location { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsSubProject { get; set; }
    }
}
