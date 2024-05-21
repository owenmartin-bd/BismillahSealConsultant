using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class AudioAnouncement
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? AudioUrl { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
