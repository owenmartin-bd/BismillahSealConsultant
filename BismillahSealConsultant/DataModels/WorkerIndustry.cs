using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class WorkerIndustry
    {
        public Guid Id { get; set; }
        public int IndustryId { get; set; }
        public int WorkerId { get; set; }
    }
}
