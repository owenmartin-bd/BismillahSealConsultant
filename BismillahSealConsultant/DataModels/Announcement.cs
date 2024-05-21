using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class Announcement
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Details { get; set; }
        public DateOnly? Date { get; set; }
    }
}
