using System;
using System.Collections.Generic;

namespace BismillahSealConsultant.DataModels
{
    public partial class Access
    {
        public Guid Id { get; set; }
        public Guid? RollId { get; set; }
        public Guid? PageId { get; set; }

        public virtual Roll? Roll { get; set; }
    }
}
