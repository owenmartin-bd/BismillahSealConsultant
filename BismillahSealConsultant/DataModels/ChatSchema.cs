using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class ChatSchema
    {
        public Guid Id { get; set; }
        public DateOnly? DateStarted { get; set; }
        public DateOnly? DateEnded { get; set; }
    }
}
