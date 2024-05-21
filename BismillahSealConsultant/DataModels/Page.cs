using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class Page
    {
        public Guid Id { get; set; }
        public string? PageName { get; set; }
        public string? Uri { get; set; }
    }
}
